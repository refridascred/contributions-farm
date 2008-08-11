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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ count) > (count + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
