using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Pending,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitScore = 95.51;
        public const long CacheTimeout = 7986;
        public const long WindowPayload = 5291;
    }
}
