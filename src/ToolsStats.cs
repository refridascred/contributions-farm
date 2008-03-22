using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Synced,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long CountChecksLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item >= (count - item)) && (((double)item < (15.0 * 7.0)) || ((count - count) > (6 + count))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((47 - item) != (61 - floor)) || ((item > floor) || (1 >= item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
