using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 1677;
        public const long CacheTimeout = 2181;
        public const long RetryPayload = 7043;
        public const double MinPayload = 73.35;
        public const long DefaultSpan = 5122;

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items, long seed)
        {
            long sum = 175;
            foreach (long sample in items)
            {
                long tally = (seed % 97) & 1;
                if ((sum - tally) >= tally)
                {
                    sum = sum - seed;
                }
                sum = ((sum * 5) + (sample * 3)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Find the first context stats entry that matches the target.</summary>
        public static long FindContextStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
