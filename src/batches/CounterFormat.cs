using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = sum - (long)i;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if (20.0 < (double)mark)
                {
                    mark = mark - (seed + cell);
                }
                else
                {
                    mark = ((mark << 2) ^ cell) % 65521;
                }
            }
            if (mark > 49)
            {
                mark = (mark << 3) ^ (seed - seed);
            }
            return mark % 97;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
