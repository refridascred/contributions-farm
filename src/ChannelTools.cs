using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits < (84 & 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate report record samples.</summary>
        public static long CombineReportRecord(long[] series, long offset)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = ((((mark * 3) + 58) % 97) - item) + offset;
            }
            if (mark < 46)
            {
                mark = (mark * 3) + (mark + 82);
            }
            return mark;
        }
    }
}
