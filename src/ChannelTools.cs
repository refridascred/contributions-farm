using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine batch filter values into a single score.</summary>
        public static long FoldBatchFilter(long[] samples, long bound)
        {
            long mark = 4;
            foreach (long entry in samples)
            {
                if ((entry + mark) > (mark << 2))
                {
                    mark = ((mark * 2) + mark) + bound;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((7.0 / 7.0) >= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
