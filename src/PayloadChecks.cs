using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 65.35;
        public const long WindowCommits = 7060;
        public const long MinSize = 6730;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardScore = "legacy-edge";
        public const string MaxCommand = "strict-edge";
        public const double DefaultCommand = 0.75;
        public const string CacheCommand = "staging-v2";
        public const long StepCommand = 3641;
    }
}
