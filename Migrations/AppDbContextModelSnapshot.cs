﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShop.Models;

namespace eShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Motorola"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Samsung"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Micromax"
                        });
                });

            modelBuilder.Entity("eShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Want to try your hand at macro-photography? Want to carry your digital life with you wherever you go? You can do these and a lot more with this phone from Motorola.Powered by a 2.0 GHz AI-capable Octa-core Processor and 4 GB of RAM, this phone can handle any task that you throw at it",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\motorola-one-macro.jpg",
                            ImageUrl = "\\Images\\motorola-one-macro.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Motorola One Macro",
                            Price = 8999m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "With 64 GB of ROM, this mobile will offer plenty of space to store all your photos and personal files. You can also expand the storage space up to 512 GB by using a microSD card. To top it off, it has 4GB of RAM to ensure seamless performance.It has a 15.49-cm HD+ screen with 19.5:9 aspect ratio",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\moto-e6s.jpg",
                            ImageUrl = "\\Images\\moto-e6s.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Moto E6s",
                            Price = 6999m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "lay games and watch movies for hours without worrying about the battery life in your phone. The Moto X Play comes with a battery life of over 30 hours. Carry it anywhere without any worries, even to the beach. The phone has a water repellent coating that makes it easy to maintain",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\motorola-moto-x-play.jpg",
                            ImageUrl = "\\Images\\motorola-moto-x-play.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Moto X Play",
                            Price = 17499m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Take your mobile experience to next level with the Samsung Galaxy J7 Prime phone. This drool-worthy phone features an attractive design so you can flaunt your style wherever you go, while the quick launch camera lets you capture pictures in seconds.It features a 13 MP rear camera that lets you take beautiful shots even in low-light.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\samsung-galaxy-j7-prime.jpg",
                            ImageUrl = "\\Images\\samsung-galaxy-j7-prime.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Samsung Galaxy J7 Prime",
                            Price = 13500m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Description = "Experience blazing-fast smartphone performance by bringing home this Samsung smartphone. Packed with stunning features, such as a Qualcomm Snapdragon 450 octa-core processor and 3 GB of RAM, this smartphone helps you multitask between several apps like a breeze.On top of that, this handset's stunning 3D prism design ensures that it looks great in your hands.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\galaxy-a20s-32-a.jpg",
                            ImageUrl = "\\Images\\galaxy-a20s-32-a.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Samsung Galaxy A20s",
                            Price = 12490m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Description = "The On Nxt is a performance beast, thanks to the powerful 1.6 GHz, octa-core processor that's aided by an impressive amount of RAM (3 GB). Furthermore, it has 16 GB of internal memory, so you can store loads of photos, videos, apps and more",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\samsung-galaxy-on-nxt.jpg",
                            ImageUrl = "\\Images\\samsung-galaxy-on-nxt.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Samsung Galaxy On Nxt",
                            Price = 11200m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            Description = "Enjoy long and fun hours of vibrant and immersive viewing experience on the Samsung Galaxy J4 Plus. You can stream your favorite TV shows or videos and watch them in stunning clarity on its 15.26 cm (6) True HD+ Infinity display. This smartphone features a 13 MP rear and 5 MP front camera with front and rear LED Flash",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\samsung-galaxy-j4-plus.jpg",
                            ImageUrl = "\\Images\\samsung-galaxy-j4-plus.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Samsung Galaxy J4 Plus",
                            Price = 10200m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            Description = "Featuring a slim 8.5 mm body and a 2.5D glass display, with Corning Gorilla Glass 5, the Micromax Canvas 2 is as sturdy as it is sleek. Powered by the Android Nougat 7 operating system, the Canvas 2 offers a seamless performance. With a 1.25 GHz MT6737 quad-core processor and a 3 GB DDR3 RAM, this smartphone is built to perform.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\micromax-canvas-2.jpg",
                            ImageUrl = "\\Images\\micromax-canvas-2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Micromax Canvas 2",
                            Price = 11999m
                        });
                });

            modelBuilder.Entity("eShop.Models.Product", b =>
                {
                    b.HasOne("eShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
