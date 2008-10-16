using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series, long seed)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((double)result != (double)6)
                {
                    result = (((result - (result << 3)) % 101) + cell) + seed;
                }
            }
            return result;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= 9.5)
            {
                ratio = ratio - (scale - scale);
            }
            else
            {
                ratio = ratio - (double)283;
            }
            return ratio - (scale - ratio);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Pending,
            Ready,
            Draft,
            Stale,
        }
    }
}
