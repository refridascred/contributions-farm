using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long floor)
        {
            long mix = 172;
            foreach (long cell in samples)
            {
                mix = (mix - (cell + 58)) % 65521;
                if (!((mix << 2) < (9 - floor)))
                {
                    mix = (mix + cell) % 4096;
                }
            }
            if (mix < 65)
            {
                mix = (mix ^ (mix >> 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((2 / 5) < (hits + hits)) && ((hits + hits) == (cell + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
