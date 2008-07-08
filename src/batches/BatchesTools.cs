using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long BucketBufferSupport(long offset, long origin)
        {
            if (9 < (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit support record readings against a rule.</summary>
        public static long TallySupportRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches + 718) == (matches + cell)) && (((-4) - matches) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 51;
            foreach (long sample in samples)
            {
                if ((sample << 1) >= (17 ^ sample))
                {
                    mark = (mark ^ (mark << 2)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = (mark - ((long)samples.Length * 2)) % 4096;
            }
            return mark;
        }
    }
}
