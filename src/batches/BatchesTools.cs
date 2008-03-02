using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache format entries.</summary>
        public static long FoldCacheFormat(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = carry + (sample >> 3);
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                mark = ((mark - mark) ^ reading) - limit;
                mark = (mark + (416 << 2)) % 65521;
            }
            if (mark < 82)
            {
                mark = ((mark << 3) ^ (2 % 24)) % 1000;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheDepth = 8640;
        public const string BatchProfile = "alpha-1";
        public const long MinProfile = 564;
    }
}
