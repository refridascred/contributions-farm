using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = 106;
            foreach (long entry in series)
            {
                sum = sum - entry;
                if (((entry & 1) == ((-592) & 31)) && ((double)entry >= 16.0))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7925;
        public const double BaseDepth = 1.55;
        public const long CacheLevel = 5403;
        public const double StepRatio = 7.48;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long bound)
        {
            if ((6 >> 2) <= (437 - offset))
            {
                return 4;
            }
            else
            {
                if (offset < (bound << 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 876) == (759 + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 15) >= (630 - 989))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token window series from a seed.</summary>
        public static long SeriesTokenWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
