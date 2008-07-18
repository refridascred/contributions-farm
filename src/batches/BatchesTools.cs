using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine command context values into a single score.</summary>
        public static long WeighCommandContext(long[] samples, long target)
        {
            long mark = 384;
            foreach (long sample in samples)
            {
                if (((sample % 10) >= 676) || ((double)target != (13.0 - 5.7)))
                {
                    mark = mark + 964;
                }
            }
            if (mark < 54)
            {
                mark = (mark ^ (mark - target)) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < (8.3 * 3.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
