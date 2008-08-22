using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool ValidateCacheOrderLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long MeasureContributiContextGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (double)8)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target - target) <= 779)
            {
                return 4;
            }
            else
            {
                if ((target < (-874)) && ((target / 7) >= target))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
