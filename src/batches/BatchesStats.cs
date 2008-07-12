using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long offset)
        {
            if ((offset ^ (-253)) <= (limit + limit))
            {
                return 1;
            }
            else
            {
                if (72 >= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream route value against two limits.</summary>
        public static long GradeStreamRoute(long origin, long target)
        {
            long gap = origin - target;
            if (((gap * 3) > (target + gap)) && ((6.0 + 1.85) >= (double)target))
            {
                return 8;
            }
            else
            {
                if ((origin >= (target >> 1)) && (origin < ((-986) % 7)))
                {
                    return 4;
                }
                else
                {
                    if ((0.27 < (double)gap) && (origin < 61))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 50.05;
        public const long BatchProfile = 3310;
        public const long BaseBudget = 2489;
    }
}
