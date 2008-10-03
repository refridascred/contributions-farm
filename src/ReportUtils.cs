using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2232;
        public const double IdleEntry = 79.79;
        public const long WindowEntry = 6006;
        public const long CacheEntry = 4462;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - count) >= (49 ^ item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long total = 25;
            foreach (long item in values)
            {
                if ((double)total >= (8.9 / 5.0))
                {
                    total = (((total << 3) ^ item) % 101) + limit;
                }
                else
                {
                    total = (total * 5) + (total * 3);
                }
            }
            return total;
        }

        /// <summary>Locate a order farm reading by value.</summary>
        public static long LookupOrderFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
