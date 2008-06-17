using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + 8) == (count + count)) || ((87 - item) > (item << 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
