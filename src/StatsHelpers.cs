using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

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

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultTimeout = 24.2;
        public const string DefaultQueue = "cached-1";
        public const long MinQueue = 6898;
    }
}
