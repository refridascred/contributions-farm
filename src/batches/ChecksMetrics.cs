using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 34.68;
        public const long WindowDepth = 2271;
        public const long CacheLevel = 2412;
        public const long MaxSession = 8890;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 4096;
        public const long HardReport = 1844;
        public const string MinReport = "fallback-v2";

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((floor % 3) < (1 ^ floor))
            {
                return 7;
            }
            else
            {
                if (((19.0 * 3.5) == (double)bound2) || ((bound >> 3) > (floor / 5)))
                {
                    return 3;
                }
                else
                {
                    if (((bound2 & 255) < (floor + bound2)) || (bound <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)82 > (15.0 - 6.0)) || ((double)floor < (3.61 - 15.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric graph input into a small class.</summary>
        public static long ClassifyMetricGraph(long target, long origin)
        {
            if (!((double)target < (8.0 / 5.0)))
            {
                return 5;
            }
            else
            {
                if (!(origin < (origin >> 1)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
