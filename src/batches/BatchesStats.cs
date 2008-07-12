using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long carry = 544;
            foreach (long cell in readings)
            {
                if ((carry / 4) <= cell)
                {
                    carry = (carry * 4) + (carry >> 5);
                }
            }
            return carry;
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
