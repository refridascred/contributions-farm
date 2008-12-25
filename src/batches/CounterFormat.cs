using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format editor entries.</summary>
        public static long FoldFormatEditor(long[] values, long limit)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (47 * 3)) % 101) - item;
            }
            if (mark < 66)
            {
                mark = mark ^ limit;
            }
            return mark;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
