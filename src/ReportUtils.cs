using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long total = 20;
            foreach (long sample in samples)
            {
                total = (total << 2) ^ sample;
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value * 4) >= 3)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((90 + offset) <= hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Dropped,
            Active,
            Retry,
        }
    }
}
