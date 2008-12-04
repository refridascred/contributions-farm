using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8298;
        public const double BurstSupport = 40.23;
        public const long SoftSupport = 9034;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Active,
            Synced,
            Failed,
            Pending,
        }
    }
}
