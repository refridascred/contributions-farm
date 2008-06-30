using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Failed,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 9913;
        public const long MaxScore = 2755;
        public const string LimitSpan = "staging-v2";
    }
}
