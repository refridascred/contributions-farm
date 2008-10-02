using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3346;
        public const string WindowCommand = "fallback-edge";
        public const long DefaultSize = 8730;
    }
}
