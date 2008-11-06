using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Active,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if (!(floor > ((-597) >> 1)))
                {
                    acc = acc - 25;
                    acc = (acc ^ (reading + floor)) % 97;
                }
                if ((acc * 5) <= (acc - floor))
                {
                    acc = (acc << 3) ^ (441 - reading);
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            New,
            Locked,
        }
    }
}
