using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Active,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = state ^ (step % 3);
                state = (state - step) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit report token readings against a rule.</summary>
        public static long MeasureReportTokenOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 61) != (limit >> 1))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
