using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long AuditSessionBufferHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((13.0 - 10.0) >= (double)datum) || ((datum >> 1) > datum)) || (6 >= (offset << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count checks route pairs that satisfy a relation.</summary>
        public static long CompareChecksRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Stale,
            Ready,
        }
    }
}
