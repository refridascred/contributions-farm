using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count layout cache pairs that satisfy a relation.</summary>
        public static long PairLayoutCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series, long seed)
        {
            long sum = 6;
            foreach (long value in series)
            {
                if ((value + 88) > value)
                {
                    sum = ((sum << 2) ^ (seed * 2)) % 101;
                }
                if ((sum / 9) <= (seed >> 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
