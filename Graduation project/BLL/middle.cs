using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class middle
    {
        Dsql dl = new Dsql();//调用Dsql类

        ////登入
        ////public Boolean loginb(string name, string pwd)
        ////{
        ////    if (dl.logind(name).Rows[0][0].ToString() == pwd)
        ////    {
        ////        return true;
        ////    }
        ////    else
        ////    {
        ////        return false;
        ////    }
        ////}

        ////查询用户id
        //public int queryidd(string name)
        //{
        //    return (int)dl.queryidd(name).Rows[0][0];
        //}

        ////注册
        ////public Boolean registerb(string name, string pwd, string gl, string sex, string dz)
        ////{
        ////    if (dl.logind(name).Rows.Count > 0)
        ////    {
        ////        return false;
        ////    }
        ////    else
        ////    {
        ////        if (dl.registerd(name, pwd, gl, sex, dz) > 0)
        ////        {
        ////            return true;
        ////        }
        ////        else
        ////        {
        ////            return false;
        ////        }
        ////    }
        ////}

        ////商品信息查询
        //public DataTable commodityqueryb(string tj)
        //{
        //    return dl.commodityqueryd(tj);
        //}

        ////通过用户id查询购物车商品id
        //public DataTable shoppingidb(int id)
        //{
        //    return dl.shoppingid(id);
        //}

        ////购物车信息
        //public DataTable shoppingcartb(int id)
        //{
        //    return dl.shoppingcartd(id);
        //}

        ////通过描述查商品id
        //public int queryspidb(string ms)
        //{
        //    return (int)dl.queryspidd(ms).Rows[0][0];
        //}

        ////通过id查商品信息
        //public DataTable idqueyb(int id)
        //{
        //    return dl.idqueryd(id);
        //}

        ////加购物车
        //public Boolean addshoppincartb(int spid, int id)
        //{
        //    Boolean b = true;
        //    for (int a = 0; a < dl.shoppingid(id).Rows.Count; a++)
        //    {
        //        if ((int)dl.shoppingid(id).Rows[a][0] == spid)
        //        {
        //            b = false;
        //            break;
        //        }
        //        else
        //        {
        //            b = true;
        //        }
        //    }
        //    if (b == true && dl.adddhopingcartd(spid, id) > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ////通过用户id查询用户信息
        //public DataTable idqueryxxb(int id)
        //{
        //    return dl.idqueryxxd(id);
        //}

        ////通过用户id查卖的商品信息
        //public DataTable idquerymb(int id)
        //{
        //    return dl.idquerymd(id);
        //}

        ////删除商品
        //public Boolean deletecommodityb(int spid, int yhid)
        //{
        //    if (dl.deletecommodityd(spid) > 0)
        //    {
        //        if (dl.deletegwcd(yhid, spid) > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ////修改商品
        //public Boolean updatecommodityb(int jg, string ms, string dm, int id, string tp)
        //{
        //    if (dl.updatecommodityd(jg, ms, dm, id, tp) > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ////添加商品
        //public Boolean insertcommodityb(int jg, string ms, string dm, int yhid, string tp)
        //{
        //    if (dl.insertcommodityd(jg, ms, dm, tp) > 0)
        //    {
        //        if (dl.insertgwcd(yhid, queryspidb(ms)) > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //改进：
        //查询所有电话号码
        public DataTable querynumberb()
        {
            return dl.querynumberd();
        }

        //登入
        public Boolean loginb(string number,string password)
        {
            return dl.logind(number, password).Rows[0]["unumber"].ToString() == number && dl.logind(number, password).Rows[0]["upassword"].ToString() == password ? true : false;
        }

        //注册
        public Boolean registerb(string number)
        {
            return dl.registerd(number) > 0 ? true : false;
        }

        //查询商品表所有数据
        public DataTable querycommodityb(string describe)
        {
            return dl.querycommodityd(describe);
        }

        //通过商品id查询商品信息
        public DataTable cidqueryb(int cid)
        {
            return dl.cidqueryd(cid);
        }

        //添加购物车
        public Boolean addshoppingcartb(int uid,int cid)
        {
            return dl.addshoppingcartd(uid, cid) > 0 ? true : false;
        }

        //购买
        public Boolean purchseb(int cid)
        {
            return dl.purchsed(cid) > 0 ? true : false;
        }

        //通过用户id查询买商品id
        public DataTable uidqueryshoppingcartb(int uid)
        {
            return dl.uidqueryshoppingcartd(uid);
        }

        //通过用户手机号查询全部信息
        public DataTable unumberqueryb(string unumber)
        {
            return dl.unumberqueryd(unumber);
        }

        //删除购物车商品
        public Boolean deleteshoppingcartb(int uid, int cid)
        {
            return dl.deleteshoppingcartd(uid, cid) > 0 ? true : false;
        }

        //个人订单信息查询
        public DataTable userqueryb(int uid,string rt)
        {
            return dl.userqueryd(uid,rt);
        }

        //添加订单信息
        public Boolean addorderb(int uid, int cid, int onumber, double ototalamount, DateTime otime)
        {
            return dl.addorderd(uid, cid, onumber, ototalamount,otime) > 0 ? true : false;
        }

        //修改用户信息
        public Boolean updateuserb(string pwd, string name, string address, int uid)
        {
            string sql;
            if(pwd.Length>0)
            {
                sql = "update usertable set upassword='" + pwd + "' where uid='" + uid + "'";
                if(name.Length>0)
                {
                    sql = "update usertable set upassword='" + pwd + "',uname='" + name + "' where uid='" + uid + "'";
                    if(address.Length>0)
                    {
                        sql = "update usertable set upassword='" + pwd + "',uname='" + name + "',uaddress='" + address + "' where uid='" + uid + "'";
                        return dl.updateuserd(pwd, name, address, uid,sql) > 0 ? true : false;
                    }
                    else
                    {
                        return dl.updateuserd(pwd, name, address, uid, sql) > 0 ? true : false;
                    }
                }
                else
                {
                    return dl.updateuserd(pwd, name, address, uid, sql) > 0 ? true : false;
                }
            }
            else if(name.Length > 0)
            {
                sql = "update usertable set upassword='" + pwd + "',uname='" + name + "' where uid='" + uid + "'";
                if (address.Length > 0)
                {
                    sql = "update usertable set upassword='" + pwd + "',uname='" + name + "',uaddress='" + address + "' where uid='" + uid + "'";
                    return dl.updateuserd(pwd, name, address, uid, sql) > 0 ? true : false;
                }
                else
                {
                    return dl.updateuserd(pwd, name, address, uid, sql) > 0 ? true : false;
                }
            }
            else if(address.Length > 0)
            {
                sql = "update usertable set upassword='" + pwd + "',uname='" + name + "',uaddress='" + address + "' where uid='" + uid + "'";
                return dl.updateuserd(pwd, name, address, uid, sql) > 0 ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}
