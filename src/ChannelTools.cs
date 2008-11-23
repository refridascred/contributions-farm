using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1567;
        public const double MaxBudget = 23.55;
        public const long SoftFilter = 1974;
        public const double BatchFilter = 49.08;
    }
}
