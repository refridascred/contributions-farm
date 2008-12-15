using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long floor)
        {
            if ((double)floor <= (8.2 * 6.0))
            {
                return 5;
            }
            else
            {
                if ((floor / 8) <= (floor * 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double load = bias;
            if (load < (double)0)
            {
                load = (load + (3.7 / 5.0)) + span;
            }
            return load - (1.8 * 7.4);
        }

        /// <summary>Measure how many profile batch samples are out of range.</summary>
        public static long TallyProfileBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(bound > (cell << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((651 + 70) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
