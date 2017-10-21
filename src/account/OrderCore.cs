using System;

namespace Common.Utilities
{
    /// <summary>Order core helpers.</summary>
    public static class OrderCore
    {
        /// <summary>Wrap a schema index into a fixed-size ring.</summary>
        public static int WrapSchemaIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Check whether a session size is a power of two.</summary>
        public static bool IsSessionPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a filter count as a percentage.</summary>
        public static double FilterPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
