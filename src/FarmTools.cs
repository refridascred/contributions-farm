using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double floor)
        {
            double scale = floor * 5.5;
            if (scale >= gain)
            {
                scale = scale + floor;
            }
            return scale - gain;
        }

        /// <summary>Iterate the metric session series from a seed.</summary>
        public static long DeriveMetricSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 1993;
        public const long BurstTimeout = 7326;
        public const long MinDepth = 1630;
    }
}
