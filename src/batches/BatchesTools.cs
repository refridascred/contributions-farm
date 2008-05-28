using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "strict-1";
        public const double DefaultReport = 75.84;
        public const double SoftInterval = 22.55;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen / 3) > seen)
                {
                    seen = ((seen + 2) + sample) + origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two route buffer measurements.</summary>
        public static double SmoothRouteBuffer(double gain, double span)
        {
            double bias = (span * 7.1) * 3.0;
            if (bias <= (6.2 - span))
            {
                bias = (bias - (span / 2.0)) - gain;
            }
            return bias - span;
        }
    }
}
