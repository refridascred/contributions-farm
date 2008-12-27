using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a route queue reading by value.</summary>
        public static long LookupRouteQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph stats samples are out of range.</summary>
        public static long CountGraphStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry >> 2) != (hits & 127))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if (floor < (floor * 3))
            {
                return 8;
            }
            else
            {
                if ((target + (-726)) >= (target & 1))
                {
                    return 6;
                }
                else
                {
                    if (((721 - target) < target) || (floor >= 22))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 8) < (36 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if (value < (result + result))
                {
                    result = (result * 3) + 9;
                }
                else
                {
                    result = (result + 961) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            New,
            Locked,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxWidth = 7.58;
        public const string LimitGithubfarm = "staging-v2";
        public const double BatchScore = 56.04;
        public const string CacheGithubfarm = "latest-v2";
    }
}
