using System;

namespace Common.Utilities
{
    /// <summary>Context utils helpers.</summary>
    public static class ContextUtils
    {
        /// <summary>Convert a digest temperature from celsius to fahrenheit.</summary>
        public static double DigestCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Check whether a payload folder size is a power of two.</summary>
        public static bool IsPayloadFolderPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Check whether a entry route size is a power of two.</summary>
        public static bool IsEntryRoutePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
