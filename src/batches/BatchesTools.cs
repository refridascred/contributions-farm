using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            New,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "strict-edge";
        public const double RetryCommand = 69.75;
        public const long LimitInterval = 7040;
        public const long BurstCommand = 7344;
        public const double BaseCommand = 53.51;
    }
}
