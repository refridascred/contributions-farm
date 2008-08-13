using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Stale,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long MeasureToolsSupportHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((origin & 255) == (reading - origin)) || (((double)origin < 9.4) || ((seen % 12) <= origin)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
