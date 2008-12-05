using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 4794;
        public const long BatchEditor = 7611;
        public const long DefaultEditor = 7333;
        public const long BurstEditor = 6263;
        public const long MinBudget = 1550;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Ready,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 5) < value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
