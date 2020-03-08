using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InvestmentAPI.Models
{
    public class StockBrokerDbContext: DbContext
    {
        public StockBrokerDbContext() { }
        public StockBrokerDbContext(DbContextOptions<StockBrokerDbContext> options) : base(options) { }

        public DbSet<StockBroker> stockBrokers { get; set; }
        public DbSet <Customer> customers { get; set; }
        public DbSet <ACompany> aCompanies { get; set; }
        public DbSet<BCompany> bCompanies { get; set; }
        public DbSet<CCompany> cCompanies { get; set; }



        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = InvestmentDatabase;";

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


        }
    }
}
