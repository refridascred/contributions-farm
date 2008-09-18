using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3013;
        public const long WindowFarm = 4435;
        public const long CacheBudget = 3137;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 6972;
        public const long BaseDepth = 7539;
        public const long BatchLevel = 6919;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
