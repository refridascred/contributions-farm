using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3024;
        public const long RetryRatio = 3756;
        public const double StepReport = 85.02;
        public const string SoftWidth = "local-1";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
