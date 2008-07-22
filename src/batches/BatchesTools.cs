using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double scale = gain;
            return scale + (bias + scale);
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((-27) >= (target - target))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
