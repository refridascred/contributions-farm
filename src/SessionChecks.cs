using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryScore = 5755;
        public const double BatchSize = 43.8;
        public const double BaseTools = 92.73;
        public const long RetryTools = 5188;
        public const string BurstCount = "primary-1";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Paused,
        }
    }
}
