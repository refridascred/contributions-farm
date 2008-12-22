using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 1785;
        public const string StepFactor = "stable-1";
        public const long IdleSession = 6426;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long seed, long floor)
        {
            long diff = seed - floor;
            if ((floor * 5) <= (diff & 127))
            {
                return 7;
            }
            else
            {
                if (((double)diff != (9.1 + 5.9)) && ((double)(-7) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (seed > diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long bound)
        {
            if ((bound > (7 + 37)) && ((0.48 - 6.7) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((limit & 3) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values, long target)
        {
            long mark = 5;
            foreach (long reading in values)
            {
                if (((double)mark != (double)target) && ((target * 4) <= (reading + reading)))
                {
                    mark = (mark << 2) ^ (mark & 1);
                }
            }
            return mark;
        }
    }
}
