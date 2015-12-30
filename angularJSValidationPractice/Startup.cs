using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angularJSValidationPractice.Startup))]
namespace angularJSValidationPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
