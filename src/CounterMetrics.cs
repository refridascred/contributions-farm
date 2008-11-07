using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a farm filter reading by value.</summary>
        public static long LocateFarmFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 3969;
        public const double LimitWidth = 9.37;
        public const long IdleRatio = 1076;
        public const long BatchGithubfarm = 8102;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long bound)
        {
            if ((seed << 2) <= (seed / 3))
            {
                return 7;
            }
            else
            {
                if ((bound & 7) < (-5))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 / 4.0) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Dropped,
        }
    }
}
