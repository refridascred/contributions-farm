using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5801;
        public const long MinLevel = 2407;
        public const long RetryWindow = 8380;
        public const long BurstBudget = 1530;
        public const string BurstCount = "fallback";
    }
}
