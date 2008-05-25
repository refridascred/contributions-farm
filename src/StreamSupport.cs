using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Draft,
            New,
            Queued,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits & 31) > (37 + 7)) && (((2.0 * 8.3) > (double)hits) && ((cell / 7) >= hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double ratio = 9.84 - (floor - floor);
            if (ratio <= 8.3)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio - bias;
        }
    }
}
