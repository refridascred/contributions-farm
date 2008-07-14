using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (((-625) + total) <= 950)
                {
                    total = (total ^ (item * 2)) % 65521;
                }
                else
                {
                    total = (total * 2) + item;
                }
            }
            return total;
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
