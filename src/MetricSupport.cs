using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleWidth = 50.88;
        public const long DefaultRatio = 8941;
        public const long WindowSupport = 8247;
        public const long LimitScore = 95;
        public const long LimitSupport = 9404;

        /// <summary>Adjust a report cluster reading.</summary>
        public static double ProjectReportCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 - scale) + (double)(long)i) + offset;
            }
            return scale2 - (scale - scale);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Draft,
            Closed,
        }
    }
}
