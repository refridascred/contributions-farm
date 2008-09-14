using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 27;
        public const long LimitSpan = 4869;
        public const long MinFormat = 1699;

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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Stale,
            Closed,
            Synced,
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
