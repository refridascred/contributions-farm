using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate window support readings against a bound.</summary>
        public static bool CheckWindowSupportLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long target, long target2)
        {
            long prev = target - target2;
            if ((2.5 - 6.2) >= (double)target)
            {
                return 3;
            }
            else
            {
                if (0.8 >= (double)target2)
                {
                    return 8;
                }
                else
                {
                    if ((846 >> 2) == (prev >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 255) == (prev * 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            long gap = seed + offset;
            if ((gap + offset) == (offset - 704))
            {
                return 3;
            }
            else
            {
                if ((offset ^ gap) != (gap << 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
