﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sieve.HR.Services.Db;

#nullable disable

namespace Sieve.HR.Migrations
{
    [DbContext(typeof(HRDbContext))]
    [Migration("20230111114114_asad3")]
    partial class asad3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_ATTENDANCE_SHEET", b =>
                {
                    b.Property<int>("ATTEND_STATUS")
                        .HasColumnType("int");

                    b.Property<int>("DAY_ID")
                        .HasColumnType("int");

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<string>("IN_TIME")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("MONTH_ID")
                        .HasColumnType("int");

                    b.Property<int>("OT_HOURS")
                        .HasColumnType("int");

                    b.Property<string>("OUT_TIME")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("ROSTER_ID")
                        .HasColumnType("int");

                    b.Property<int>("YEAR_ID")
                        .HasColumnType("int");

                    b.ToTable("HR_ATTENDANCE_SHEET");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_COMPANY", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("COMP_ADDR")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("COMP_NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MAX_EMP_NO")
                        .HasColumnType("int");

                    b.Property<int>("MAX_SALARY")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HR_COMPANY");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            COMP_ADDR = "Dhaka, Bangladesh",
                            COMP_NAME = "Sieve Org",
                            MAX_EMP_NO = 1000,
                            MAX_SALARY = 100000000
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_DEPARTMENT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("COMP_ID")
                        .HasColumnType("int");

                    b.Property<string>("DEPT_ADDR")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("DEPT_NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("HEAD_EMP_ID")
                        .HasColumnType("int");

                    b.Property<int>("MAX_EMP_NO")
                        .HasColumnType("int");

                    b.Property<int>("MAX_SALARY")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("COMP_ID");

                    b.ToTable("HR_DEPARTMENT");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            COMP_ID = 1,
                            DEPT_ADDR = "First Floor, Mail Branch",
                            DEPT_NAME = "Admin",
                            HEAD_EMP_ID = 1,
                            MAX_EMP_NO = 10,
                            MAX_SALARY = 1000000
                        },
                        new
                        {
                            ID = 2,
                            COMP_ID = 1,
                            DEPT_ADDR = "Second Floor, Mail Branch",
                            DEPT_NAME = "Sales",
                            HEAD_EMP_ID = 2,
                            MAX_EMP_NO = 10,
                            MAX_SALARY = 1000000
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_DESIGNATIONS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FULL_FORM")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MAX_SALARY")
                        .HasColumnType("int");

                    b.Property<int>("MIN_SALARY")
                        .HasColumnType("int");

                    b.Property<int>("PARENT_ID")
                        .HasColumnType("int");

                    b.Property<string>("SHORT_FORM")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("HR_DESIGNATIONS");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FULL_FORM = "Cheif Executive Officer",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 0,
                            SHORT_FORM = "CEO"
                        },
                        new
                        {
                            ID = 2,
                            FULL_FORM = "Executive Director",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 1,
                            SHORT_FORM = "ED"
                        },
                        new
                        {
                            ID = 3,
                            FULL_FORM = "Cheif Operating Director",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 2,
                            SHORT_FORM = "COO"
                        },
                        new
                        {
                            ID = 4,
                            FULL_FORM = "General Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 3,
                            SHORT_FORM = "GM"
                        },
                        new
                        {
                            ID = 5,
                            FULL_FORM = "Deputy General Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 4,
                            SHORT_FORM = "DGM"
                        },
                        new
                        {
                            ID = 6,
                            FULL_FORM = "Assistant General Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 5,
                            SHORT_FORM = "AGM"
                        },
                        new
                        {
                            ID = 7,
                            FULL_FORM = "Senior Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 6,
                            SHORT_FORM = "SM"
                        },
                        new
                        {
                            ID = 8,
                            FULL_FORM = "Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 7,
                            SHORT_FORM = "M"
                        },
                        new
                        {
                            ID = 9,
                            FULL_FORM = "Deputy Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 8,
                            SHORT_FORM = "Dym"
                        },
                        new
                        {
                            ID = 10,
                            FULL_FORM = "Assistant Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 9,
                            SHORT_FORM = "AM"
                        },
                        new
                        {
                            ID = 11,
                            FULL_FORM = "Sub Assistant Manager",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 10,
                            SHORT_FORM = "SAM"
                        },
                        new
                        {
                            ID = 12,
                            FULL_FORM = "Trainee Executive",
                            MAX_SALARY = 9999999,
                            MIN_SALARY = 100000,
                            PARENT_ID = 11,
                            SHORT_FORM = "TE"
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_DUTY_ROSTER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DUTY_ROSTER_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IN_TIME")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("MAX_OT_HOUR")
                        .HasColumnType("int");

                    b.Property<string>("OUT_TIME")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("ID");

                    b.ToTable("HR_DUTY_ROSTER");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DUTY_ROSTER_NAME = "General Shift",
                            IN_TIME = "0900",
                            MAX_OT_HOUR = 0,
                            OUT_TIME = "1700"
                        },
                        new
                        {
                            ID = 2,
                            DUTY_ROSTER_NAME = "Morning Shift",
                            IN_TIME = "0600",
                            MAX_OT_HOUR = 2,
                            OUT_TIME = "1800"
                        },
                        new
                        {
                            ID = 3,
                            DUTY_ROSTER_NAME = "Evening Shift",
                            IN_TIME = "1800",
                            MAX_OT_HOUR = 2,
                            OUT_TIME = "0600"
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EDU_TYPE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("TYPE_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("HR_EDU_TYPE");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            TYPE_NAME = "Institution"
                        },
                        new
                        {
                            ID = 2,
                            TYPE_NAME = "Training"
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BIRTH_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CONTACT_NO")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EMAIL_ID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FATHER_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FULL_NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GENDER_ID")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("MARITAIL_STATUS")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MOTHER_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NATIONALITY")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NATIONAL_ID")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PARENTS_CONACT")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PARMANENT_ADDRESS")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PASSPORT_ID")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRESENT_ADDRESS")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SPOUSE_NAME")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("HR_EMP_DETAIL");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_EDU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("EDU_GRADE")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EDU_TITLE")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EDU_TYPE_ID")
                        .HasColumnType("int");

                    b.Property<int>("EDU_YEAR")
                        .HasColumnType("int");

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<string>("INSTITUE_NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("HR_EMP_EDU");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_JOB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("APPROVED_BY")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CONF_DATE")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("DESIG_ID")
                        .HasColumnType("int");

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("END_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("GROSS_SALARY")
                        .HasColumnType("int");

                    b.Property<int>("INITIATED_BY")
                        .HasColumnType("int");

                    b.Property<int>("SECTION_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("START_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("VERIFIED_BY")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HR_EMP_JOB");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_LEAVE_APPS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("APPROVED_BY")
                        .HasColumnType("int");

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FROM_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("LEAVE_DETAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LEAVE_TYPE_ID")
                        .HasColumnType("int");

                    b.Property<int>("TOTAL_DAYS")
                        .HasColumnType("int");

                    b.Property<DateTime>("TO_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("VERIFY_BY")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HR_EMP_LEAVE_APPS");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_LEAVE_BALANCE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<int>("LEAVE_QTY")
                        .HasColumnType("int");

                    b.Property<int>("YEAR_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HR_EMP_LEAVE_BALANCE");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_REF", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DESIGNATION")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<string>("REF_ADDR")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("REF_CONTACT")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("REF_EMAIL")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("REF_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("EMP_ID");

                    b.ToTable("HR_EMP_REF");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_ROSTER", b =>
                {
                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<int>("HEAD_ID")
                        .HasColumnType("int");

                    b.Property<int>("ROSTER_ID")
                        .HasColumnType("int");

                    b.Property<int>("SUPERVISOR_ID")
                        .HasColumnType("int");

                    b.Property<int>("WEEKEND_DAYNO")
                        .HasColumnType("int");

                    b.HasKey("EMP_ID");

                    b.HasIndex("HEAD_ID");

                    b.HasIndex("ROSTER_ID");

                    b.HasIndex("SUPERVISOR_ID");

                    b.ToTable("HR_EMP_ROSTER");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_SALARY", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("EMP_ID")
                        .HasColumnType("int");

                    b.Property<int>("SALARY_AMNT")
                        .HasColumnType("int");

                    b.Property<int>("SALARY_TYPE_ID")
                        .HasColumnType("int");

                    b.Property<int>("YYYYMM")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EMP_ID");

                    b.HasIndex("SALARY_TYPE_ID");

                    b.ToTable("HR_EMP_SALARY");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_HOLIDAY_CALENDER", b =>
                {
                    b.Property<int>("YEAR_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("MONTH_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("DAY_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("HOLIDAY_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("YEAR_ID", "MONTH_ID", "DAY_ID");

                    b.ToTable("HR_HOLIDAY_CALENDER");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_LEAVE_TYPE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("TYPE_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TYPE_QTY")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HR_LEAVE_TYPE");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            TYPE_NAME = "Casual",
                            TYPE_QTY = 10
                        },
                        new
                        {
                            ID = 2,
                            TYPE_NAME = "Sick",
                            TYPE_QTY = 14
                        },
                        new
                        {
                            ID = 3,
                            TYPE_NAME = "Earned",
                            TYPE_QTY = 0
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_SALARY_TYPE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("TYPE_EFFECT")
                        .HasColumnType("int");

                    b.Property<string>("TYPE_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("HR_SALARY_TYPE");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            TYPE_EFFECT = 0,
                            TYPE_NAME = "Salary"
                        },
                        new
                        {
                            ID = 2,
                            TYPE_EFFECT = 0,
                            TYPE_NAME = "House Rent"
                        },
                        new
                        {
                            ID = 3,
                            TYPE_EFFECT = 0,
                            TYPE_NAME = "Medical"
                        },
                        new
                        {
                            ID = 4,
                            TYPE_EFFECT = 0,
                            TYPE_NAME = "Transport"
                        },
                        new
                        {
                            ID = 5,
                            TYPE_EFFECT = 0,
                            TYPE_NAME = "Mobile"
                        },
                        new
                        {
                            ID = 6,
                            TYPE_EFFECT = 1,
                            TYPE_NAME = "Deposit"
                        },
                        new
                        {
                            ID = 7,
                            TYPE_EFFECT = 1,
                            TYPE_NAME = "Loan"
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_SECTIONS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DEPT_ID")
                        .HasColumnType("int");

                    b.Property<int>("HEAD_EMP_ID")
                        .HasColumnType("int");

                    b.Property<int>("MAX_EMP_NO")
                        .HasColumnType("int");

                    b.Property<int>("MAX_SALARY")
                        .HasColumnType("int");

                    b.Property<string>("SECT_ADDR")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SECT_NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("DEPT_ID");

                    b.ToTable("HR_SECTIONS");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DEPT_ID = 1,
                            HEAD_EMP_ID = 1,
                            MAX_EMP_NO = 10,
                            MAX_SALARY = 1000000,
                            SECT_ADDR = "First Floor, Mail Branch",
                            SECT_NAME = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            DEPT_ID = 2,
                            HEAD_EMP_ID = 2,
                            MAX_EMP_NO = 10,
                            MAX_SALARY = 1000000,
                            SECT_ADDR = "Second Floor, Mail Branch",
                            SECT_NAME = "IT Product"
                        });
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_DEPARTMENT", b =>
                {
                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_COMPANY", "HR_COMPANY")
                        .WithMany("HR_DEPARTMENT_NAV")
                        .HasForeignKey("COMP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HR_COMPANY");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_REF", b =>
                {
                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", "EMP")
                        .WithMany()
                        .HasForeignKey("EMP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EMP");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_ROSTER", b =>
                {
                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", "EMP")
                        .WithOne("HR_EMP_ROSTER_EMP")
                        .HasForeignKey("Sieve.HR.Areas.Admin.Models.HR_EMP_ROSTER", "EMP_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_HR_EMP_ROSTER_HR_EMP_DETAIL");

                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", "HEAD")
                        .WithMany("HR_EMP_ROSTER_HEAD")
                        .HasForeignKey("HEAD_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_HR_EMP_ROSTER_HR_EMP_HEAD");

                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_DUTY_ROSTER", "ROSTER")
                        .WithMany("HR_EMP_ROSTERS")
                        .HasForeignKey("ROSTER_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_HR_EMP_ROSTER_HR_DUTY_ROSTER");

                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", "SUPERVISOR")
                        .WithMany("HR_EMP_ROSTER_SUPERVISOR")
                        .HasForeignKey("SUPERVISOR_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_HR_EMP_ROSTER_HR_EMP_SUPERVISOR");

                    b.Navigation("EMP");

                    b.Navigation("HEAD");

                    b.Navigation("ROSTER");

                    b.Navigation("SUPERVISOR");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_SALARY", b =>
                {
                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", "HR_EMP_DETAIL")
                        .WithMany()
                        .HasForeignKey("EMP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_SALARY_TYPE", "HR_SALARY_TYPE")
                        .WithMany()
                        .HasForeignKey("SALARY_TYPE_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HR_EMP_DETAIL");

                    b.Navigation("HR_SALARY_TYPE");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_SECTIONS", b =>
                {
                    b.HasOne("Sieve.HR.Areas.Admin.Models.HR_DEPARTMENT", "HR_DEPARTMENT")
                        .WithMany("HR_SECTIONS_NAV")
                        .HasForeignKey("DEPT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HR_DEPARTMENT");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_COMPANY", b =>
                {
                    b.Navigation("HR_DEPARTMENT_NAV");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_DEPARTMENT", b =>
                {
                    b.Navigation("HR_SECTIONS_NAV");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_DUTY_ROSTER", b =>
                {
                    b.Navigation("HR_EMP_ROSTERS");
                });

            modelBuilder.Entity("Sieve.HR.Areas.Admin.Models.HR_EMP_DETAIL", b =>
                {
                    b.Navigation("HR_EMP_ROSTER_EMP");

                    b.Navigation("HR_EMP_ROSTER_HEAD");

                    b.Navigation("HR_EMP_ROSTER_SUPERVISOR");
                });
#pragma warning restore 612, 618
        }
    }
}
