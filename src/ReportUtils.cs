using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 6375;
        public const long IdleChannel = 2011;
        public const string StepChannel = "latest-v2";
        public const long BurstChannel = 832;
        public const long CacheDepth = 8880;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 6623;
        public const long DefaultLevel = 5046;
        public const long DefaultInterval = 3153;
        public const long HardStats = 3758;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long limit)
        {
            long edge = target - limit;
            if (!((1 >> 5) < target))
            {
                return 0;
            }
            else
            {
                if ((target + 49) == (edge / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((step - 97) != (573 / 2))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
