using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long origin)
        {
            long state = 2;
            foreach (long cell in values)
            {
                if (!((5 + 944) <= origin))
                {
                    state = (state - origin) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4730;
        public const string DefaultBudget = "strict-v2";
        public const long IdleMetrics = 6109;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long bound)
        {
            long delta = floor - bound;
            if ((((-642) + floor) > bound) && ((delta >> 2) <= (bound + bound)))
            {
                return 0;
            }
            else
            {
                if (!((delta % 16) >= ((-833) + 1)))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) == (floor + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
