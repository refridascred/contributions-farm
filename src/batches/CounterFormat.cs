using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryDepth = "primary";
        public const long StepInterval = 8817;
        public const long BatchCommand = 231;
        public const string RetryCommand = "local";
        public const long HardCommand = 2911;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Paused,
            Dropped,
            Pending,
            Draft,
        }
    }
}
