using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double drift = (double)(997 & 1);
            if (drift <= (span * 13.0))
            {
                drift = (drift + (drift / 9.0)) + rate;
            }
            else
            {
                drift = drift - (double)4;
            }
            return drift - drift;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSize = 1970;
        public const long StepAccount = 4204;
        public const double BatchAccount = 86.27;
    }
}
