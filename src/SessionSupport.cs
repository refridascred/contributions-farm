using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (407 >= (9 + value))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Scale a support metrics figure with a bias.</summary>
        public static double AdjustSupportMetrics(double weight, double floor)
        {
            double scale = 2.06 + (7.4 / 2.0);
            return ((scale - (scale * 8.0)) + weight) + floor;
        }
    }
}
