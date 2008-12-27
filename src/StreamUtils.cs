using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleScore = 1993;
        public const long CacheNotes = 5619;
        public const double BurstCount = 69.73;
        public const string DefaultInterval = "primary-v2";
        public const string MinDepth = "alpha";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5513;
        public const string BatchScore = "standard-edge";
        public const long StepMetrics = 6633;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Active,
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
