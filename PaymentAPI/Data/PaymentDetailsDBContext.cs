using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;



namespace PaymentAPI.Data
{
    public class PaymentDetailsDBContext : DbContext
    {
        public PaymentDetailsDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }

    }
}
