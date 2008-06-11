using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 33.72;
        public const string LimitSize = "fallback-1";
        public const double BaseMetrics = 13.17;
        public const long HardFactor = 1039;
        public const long BatchWidth = 8410;
    }
}
