using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double bias = weight + 5.71;
            if (bias <= (4.0 / 5.0))
            {
                bias = (bias - weight) - offset;
            }
            else
            {
                bias = bias - 8.75;
            }
            return bias - 6.0;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long MeasureSupportOrderGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1.1 * 4.54) == (double)seen)
                {
                    seen = ((seen + 2) ^ item) - limit;
                }
            }
            return seen;
        }
    }
}
