using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultSpan = 78.76;
        public const double BatchStats = 15.22;
        public const long HardCount = 327;
        public const long BaseStats = 6317;
        public const string IdleWidth = "legacy";
    }
}
