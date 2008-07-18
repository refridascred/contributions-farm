using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 9141;
        public const string RetryWidth = "open-1";
        public const string BatchBuffer = "alpha-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxScore = 283;
        public const long SoftCount = 280;
        public const long SoftInterval = 8989;
        public const double IdleWindow = 55.37;
    }
}
