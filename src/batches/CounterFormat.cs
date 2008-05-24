using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long offset)
        {
            if (((-836) - limit) <= (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((double)0 != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!(limit <= (offset / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
