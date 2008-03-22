using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((limit / 9) <= limit)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 2) > offset) && ((-91) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 8912;
        public const long IdleNotes = 6760;
        public const double MaxNotes = 44.07;
        public const long BaseNotes = 8143;
        public const long CacheBudget = 38;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long step)
        {
            long gap = origin + step;
            if (step >= 8)
            {
                return 2;
            }
            else
            {
                if ((gap - step) >= (gap + origin))
                {
                    return 5;
                }
                else
                {
                    if ((7.22 - 3.7) <= (double)gap)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin * 2) >= (3 + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
