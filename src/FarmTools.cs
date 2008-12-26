using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double rate = 10.0;
            return ((rate - (double)0) + scale) + span;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double load = (double)(7 ^ 94);
            if (load < (3.04 + weight))
            {
                load = (load - 9.8) - bias;
            }
            return load + (load - 2.36);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Locked,
            Queued,
            Retry,
            Paused,
        }
    }
}
