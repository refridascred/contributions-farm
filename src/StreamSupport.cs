using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc + ((long)i ^ (long)i)) % 101;
                if (!!((acc - acc) > ((long)i % 12)))
                {
                    acc = ((acc * 4) + (bound / 2)) % 4096;
                }
                if (!((bound << 1) < ((long)i * 2)))
                {
                    acc = acc - (16 + acc);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of batches cache entries.</summary>
        public static long ScoreBatchesCache(long[] samples, long origin)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                if (!((mark - cell) == (1 << 2)))
                {
                    mark = ((mark << 2) ^ (cell / 2)) - origin;
                }
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "local";
        public const double SoftDepth = 3.62;
        public const double MaxDepth = 67.79;
        public const double BaseCache = 26.83;
        public const double DefaultCache = 9.02;
    }
}
