using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4752;
        public const long BaseGraph = 5786;
        public const string RetrySize = "open";

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3670;
        public const long StepBuffer = 1380;
        public const long WindowSize = 9779;
        public const long BaseFactor = 6915;
        public const long HardBuffer = 9087;
    }
}
