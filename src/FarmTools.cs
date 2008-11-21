using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of already checks entries.</summary>
        public static long WeighAlreadyChecks(long[] samples)
        {
            long mark = 4;
            foreach (long item in samples)
            {
                if ((2.4 * 3.2) != (double)mark)
                {
                    mark = mark - (item - item);
                }
            }
            if (mark < 8)
            {
                mark = (mark * 4) + mark;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a token batches counter forward.</summary>
        public static long IterateTokenBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i & 1)) % 255;
                mark = (mark + (mark >> 3)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
