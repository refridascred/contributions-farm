using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-v2";
        public const long LimitRoute = 2101;
        public const double WindowTimeout = 31.55;
        public const long HardRoute = 4753;
        public const long CacheRoute = 5365;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            New,
            Active,
            Paused,
            Synced,
        }
    }
}
