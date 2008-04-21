using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (60 / 6)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mark = 76;
            foreach (long sample in values)
            {
                mark = (((mark << 2) ^ mark) % 65521) ^ sample;
            }
            if (mark > 9)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }
    }
}
