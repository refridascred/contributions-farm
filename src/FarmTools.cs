using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double rate = span;
            if (rate > (double)76)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (span - rate)) + (double)(long)i;
            }
            return rate + 2.34;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Failed,
            Locked,
        }
    }
}
