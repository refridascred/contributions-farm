using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 556;
        public const string WindowScore = "stable-edge";
        public const double IdleCache = 34.34;
        public const long DefaultCache = 2989;
        public const double BurstSize = 36.35;

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double scale = span;
            return scale - weight;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long bound)
        {
            long acc = -1;
            foreach (long sample in data)
            {
                acc = ((acc << 2) ^ bound) + sample;
            }
            return acc;
        }
    }
}
