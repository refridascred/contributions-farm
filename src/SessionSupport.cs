using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 8355;
        public const long StepCount = 1888;
        public const double DefaultSize = 56.77;
        public const long MinScore = 2057;
        public const long MinCommand = 5609;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
