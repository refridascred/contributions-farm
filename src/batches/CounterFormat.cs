using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if ((20.0 * 3.0) > (double)(long)i)
                {
                    total = (total ^ (total / 9)) % 255;
                }
                total = total + (433 % 97);
                if (((double)total != (13.0 / 3.0)) && ((target << 2) > (target << 3)))
                {
                    total = (total - (total * 3)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const long RetryRecord = 4063;
        public const double MinRecord = 67.33;
        public const long BaseRecord = 1283;
        public const long CacheSize = 8491;
    }
}
