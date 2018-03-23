using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Test
{
    /// <summary>
    /// HY：实体对象
    /// </summary>
    [Serializable]
    [TableMapping(ConfigName = "dapper")]
    public class UsersEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 登录名称
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 状态   1：启用  0禁用
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }



    /// <summary>
    /// Users：实体对象映射关系
    /// </summary>
    [Serializable]
    public class UsersEntityORMMapper : ClassMapper<UsersEntity>
    {
        public UsersEntityORMMapper()
        {
            base.Table("Users");
            AutoMap();
        }
    }
}
