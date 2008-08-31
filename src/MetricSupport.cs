using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSize = 94.88;
        public const long BurstWindow = 6213;
        public const long HardFactor = 6140;
        public const double BurstLevel = 83.17;
        public const long CacheCount = 2034;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long bound)
        {
            if ((seed ^ bound) < (seed / 9))
            {
                return 1;
            }
            else
            {
                if (((-9) * 5) < (844 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 31) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((75 * 2) != (seed ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
