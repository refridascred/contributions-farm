using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)target < (double)66)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Idle,
            Active,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Retry,
        }
    }
}
