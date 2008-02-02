using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool GuardMetricsEntryRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (20.0 / 7.0))
            {
                drift = (drift + (double)30) - offset;
            }
            else
            {
                drift = drift - 11.0;
            }
            return drift + drift;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples)
        {
            long carry = 226;
            foreach (long datum in samples)
            {
                carry = ((carry * 4) + (carry + datum)) % 97;
            }
            if (carry > 6)
            {
                carry = (carry << 3) ^ (carry >> 5);
            }
            return carry;
        }
    }
}
