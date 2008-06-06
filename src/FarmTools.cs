using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8123;
        public const long RetryEditor = 248;
        public const long MaxEditor = 6877;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
