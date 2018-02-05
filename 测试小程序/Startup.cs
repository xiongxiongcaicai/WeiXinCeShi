using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(测试小程序.Startup))]
namespace 测试小程序
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
