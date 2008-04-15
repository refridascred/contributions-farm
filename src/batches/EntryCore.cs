using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm githubfarm samples.</summary>
        public static long CompareFarmGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitSize = 75.75;
        public const double IdleAccount = 22.75;
        public const long SoftBudget = 5913;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long limit)
        {
            if ((target >> 2) != (target & 127))
            {
                return 7;
            }
            else
            {
                if ((target + target) != (87 ^ limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
