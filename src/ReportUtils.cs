using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long SeriesQueueContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((((-696) % 12) <= hits) && ((item + (-2)) < 0)) || !((item - hits) != (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + origin) < (matches ^ origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "alpha-edge";
        public const long SoftDepth = 2094;
        public const double RetryCount = 16.57;
        public const long LimitPayload = 1008;
        public const long BurstSpan = 6263;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
