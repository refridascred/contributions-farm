using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Stale,
            Active,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 631;
        public const long BurstWindow = 7541;
        public const long BurstSpan = 7510;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSize = 58.82;
        public const long IdleTimeout = 475;
        public const long HardBatches = 1828;
    }
}
