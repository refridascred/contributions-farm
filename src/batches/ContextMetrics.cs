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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches << 1) == (matches / 3)) && (18.0 < (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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
