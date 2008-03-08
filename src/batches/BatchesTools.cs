using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double scale = (14.0 / 7.0) - 13.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (bias + 17.0)) + (double)(long)i) + ratio;
            }
            return scale - (bias - scale);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item % 100) > (tally + 837)) || ((tally + item) >= (tally << 1)))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
