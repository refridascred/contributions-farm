using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 6772;
        public const double RetryCount = 69.97;
        public const long BurstTimeout = 3888;
        public const double WindowReport = 36.5;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
