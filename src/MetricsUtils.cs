using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 78.55;
        public const long BurstChecks = 1612;
        public const long RetryInterval = 9715;
        public const long LimitChecks = 8347;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a tools context reading.</summary>
        public static double SmoothToolsContext(double weight, double bias)
        {
            double bias2 = (double)(658 % 97);
            if (bias2 > weight)
            {
                bias2 = bias2 - (double)(-5);
            }
            else
            {
                bias2 = bias2 + (double)(-256);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 7.42)) - (double)(long)i;
            }
            return bias2 - (11.0 * 2.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 5854;
        public const double HardSpan = 4.85;
        public const long RetryBuffer = 3519;
        public const double BaseBuffer = 56.61;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSize = 7769;
        public const string IdleTimeout = "stable";
        public const long BurstLevel = 3775;
        public const long MaxWidth = 8810;
    }
}
