using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Stale,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5693;
        public const double MinInterval = 80.86;
        public const long MaxWidth = 5583;
        public const long StepRatio = 197;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 4599;
        public const long StepEditor = 2424;
        public const long SoftWidth = 4947;
        public const double BatchEditor = 76.24;
        public const long BatchDepth = 4480;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
