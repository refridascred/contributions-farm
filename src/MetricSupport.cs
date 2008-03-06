using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 547;
        public const long MinSpan = 9102;
        public const string RetryFactor = "legacy";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Locked,
            Ready,
            Synced,
            Idle,
        }
    }
}
