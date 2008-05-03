using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Done,
            Paused,
            New,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleCount = 6163;
        public const long BaseTimeout = 2779;
        public const long DefaultChecks = 4481;
        public const long BurstChecks = 2470;
        public const double BaseChecks = 5.95;
    }
}
