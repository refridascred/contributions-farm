using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "latest-v2";
        public const long BurstSpan = 1660;
        public const string LimitBudget = "alpha-v2";
        public const long LimitInterval = 9221;
    }
}
