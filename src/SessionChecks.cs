using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 63.28;
        public const string WindowDepth = "stable-1";
        public const long MaxSize = 3253;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFactor = 3965;
        public const long WindowTimeout = 5982;
        public const double RetryFarm = 24.18;
        public const double HardFarm = 4.77;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
