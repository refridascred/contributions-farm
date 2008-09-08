using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstSpan = 33;
        public const long RetryCommand = 539;
        public const string SoftLevel = "alpha";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
