using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleScore = 77.34;
        public const double IdleCommand = 87.69;
        public const long IdleWidth = 2203;
        public const long CacheDepth = 1775;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item < (bound << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
