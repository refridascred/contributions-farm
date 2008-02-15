using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9834;
        public const long SoftContributi = 3412;
        public const long CacheContributi = 3462;
        public const long BurstLevel = 91;

        /// <summary>Look up the position of a entry cache sample.</summary>
        public static long SeekEntryCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (item << 3))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
