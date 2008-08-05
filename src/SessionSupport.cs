using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 1654;
        public const long MaxCount = 7203;
        public const long BatchScore = 7611;
    }
}
