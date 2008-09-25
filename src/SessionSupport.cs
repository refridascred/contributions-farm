using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Dropped,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 6422;
        public const double StepQueue = 0.86;
        public const double BaseQueue = 21.97;
        public const long RetryRatio = 7551;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
