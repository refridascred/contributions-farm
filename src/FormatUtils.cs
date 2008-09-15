using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Failed,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series, long bound)
        {
            long state = 90;
            foreach (long cell in series)
            {
                state = ((state * 5) + cell) + bound;
            }
            if (state < 703)
            {
                state = (state ^ (state >> 3)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((2 * 4) <= hits)
                {
                    hits = ((hits + 3) + reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSize = 2551;
        public const double RetryWidth = 75.6;
        public const string MinLayout = "latest-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
