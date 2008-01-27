using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Done,
            Active,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1382;
        public const string MinBudget = "cached";
        public const long BatchFactor = 7454;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 39;
        public const string StepSize = "strict-1";
        public const long CacheReport = 8324;
        public const long RetryScore = 9787;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
