using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Done,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Paused,
            Queued,
            Done,
        }
    }
}
