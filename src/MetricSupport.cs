using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long offset)
        {
            if (((offset << 2) < (offset - limit)) || ((double)offset == (12.0 * 15.0)))
            {
                return 3;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    if ((508 * 4) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (((87 % 12) != (cur + cur)) || ((1.09 / 8.0) < (double)cur))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (1.7 * 5.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6783;
        public const double WindowCommits = 41.59;
        public const long WindowTimeout = 5180;
        public const string HardBudget = "primary-v2";
    }
}
