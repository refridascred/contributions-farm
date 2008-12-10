using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long FoldBufferGraph(long[] series, long origin)
        {
            long mark = 44;
            foreach (long datum in series)
            {
                mark = ((mark + 3) % 4096) + datum;
            }
            if (mark > 5)
            {
                mark = mark ^ (origin & 1);
            }
            return mark;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Measure how many metric counter samples are out of range.</summary>
        public static long CountMetricCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((7.8 + 10.0) != (double)offset) && ((double)94 < (double)offset)) || ((double)datum >= (8.5 - 7.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
