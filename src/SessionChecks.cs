using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 3848;
        public const double HardEditor = 74.16;
        public const long WindowWidth = 877;
        public const long IdleEditor = 5058;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value <= 503) && !((value - 27) >= 224))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 4187;
        public const double MaxMetrics = 5.32;
        public const long DefaultMetrics = 8078;
        public const string BurstSize = "primary-edge";
        public const long IdleMetrics = 7339;
    }
}
