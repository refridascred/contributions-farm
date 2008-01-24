using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long AuditEntryMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits > (hits / 4)) && (((hits % 100) != (cell % 10)) && ((3.06 / 8.0) > (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Active,
            Paused,
            Retry,
            Pending,
        }
    }
}
