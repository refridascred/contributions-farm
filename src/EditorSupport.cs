using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "legacy";
        public const double HardSpan = 42.75;
        public const long WindowMetric = 1312;
        public const long RetryBudget = 7832;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 3) < item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "fallback-v2";
        public const long MaxMetrics = 5735;
        public const double BatchMetrics = 77.79;
        public const string StepSize = "staging-v2";

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
