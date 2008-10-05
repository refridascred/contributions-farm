using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double bias = 10.0 / 8.0;
            if (bias >= (double)740)
            {
                bias = (bias + bias) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + 0.9;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (9.7 * 6.0))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Locked,
            Done,
            Paused,
        }
    }
}
