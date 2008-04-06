using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9552;
        public const long DefaultRatio = 9044;
        public const string StepEditor = "open-edge";
        public const long IdleEditor = 1606;
        public const double HardScore = 6.98;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Active,
            Synced,
            Stale,
            Failed,
        }
    }
}
