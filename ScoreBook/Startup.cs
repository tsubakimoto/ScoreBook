using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoreBook.Startup))]
namespace ScoreBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
