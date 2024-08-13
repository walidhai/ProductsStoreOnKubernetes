using MvcApp.Models;

namespace MvcApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductsContext context)
        {
            context.Database.EnsureCreated();

        }
    }
}
