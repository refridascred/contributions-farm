using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a context window sample.</summary>
        public static long LookupContextWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter format entries that pass the check.</summary>
        public static long TallyFilterFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9.63 - 3.0) < (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series, long limit)
        {
            long result = 93;
            foreach (long entry in series)
            {
                if ((result / 7) != (result - limit))
                {
                    result = ((result ^ (limit % 100)) % 101) ^ entry;
                }
            }
            if (result < 6)
            {
                result = ((result << 2) ^ (limit + limit)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 3) == (tally >> 5)) && ((origin - 2) != (origin / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account channel value from a seed.</summary>
        public static long DeriveAccountChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((acc & 15) < (long)i))
                {
                    acc = acc - offset;
                    acc = ((acc << 3) ^ (offset << 3)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
