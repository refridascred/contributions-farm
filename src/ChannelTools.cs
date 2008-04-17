using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 8050;
        public const string RetryAccount = "stable-v2";
        public const string IdleAccount = "primary";
        public const long StepAccount = 1995;
        public const long CacheFactor = 5111;
    }
}
