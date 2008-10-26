using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats graph readings against a bound.</summary>
        public static bool GuardStatsGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double mean = 8.7;
            if (mean >= (double)206)
            {
                mean = ((mean - (double)807) - scale) - span;
            }
            return mean + (mean * 4.77);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Ready,
            Closed,
            Pending,
            Failed,
        }
    }
}
