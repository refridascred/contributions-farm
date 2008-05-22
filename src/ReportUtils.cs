using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSize = 1483;
        public const long IdleGithubfarm = 5410;
        public const double MaxGithubfarm = 47.82;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 8895;
        public const long DefaultBudget = 8695;
        public const string MaxLevel = "primary-edge";
        public const long SoftEntry = 5792;
        public const string CacheEntry = "primary";

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Queued,
        }
    }
}
