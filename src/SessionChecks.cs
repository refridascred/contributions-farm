using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "standard-edge";
        public const double DefaultRecord = 79.48;
        public const long SoftSpan = 2893;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4201;
        public const double WindowCount = 25.29;
        public const long BaseLevel = 5649;
        public const double BaseMetric = 57.37;
        public const string BaseWidth = "staging-v2";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a route cache figure with a bias.</summary>
        public static double SmoothRouteCache(double scale, double span)
        {
            double rate = span;
            if (rate <= (scale / 2.0))
            {
                rate = rate - (8.97 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (double)9;
        }
    }
}
