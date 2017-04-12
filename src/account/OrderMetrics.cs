using System;

namespace Common.Utilities
{
    /// <summary>Order metrics helpers.</summary>
    public static class OrderMetrics
    {
        /// <summary>Check whether a ticket editor size is a power of two.</summary>
        public static bool IsTicketEditorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a digest count as a percentage.</summary>
        public static double DigestPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Sum the decimal digits of a entry id.</summary>
        public static int EntryDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
        }

        /// <summary>Check whether a batch record size is a power of two.</summary>
        public static bool IsBatchRecordPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
