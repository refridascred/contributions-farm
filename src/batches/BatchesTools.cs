using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double rate = offset;
            if (rate < (13.0 - offset))
            {
                rate = rate + scale;
            }
            return rate + (offset * 7.0);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 3) != (hits >> 5))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
