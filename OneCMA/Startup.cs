using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneCMA.Startup))]
namespace OneCMA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
