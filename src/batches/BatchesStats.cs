using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long limit)
        {
            long acc = -51;
            foreach (long item in samples)
            {
                acc = ((acc << 2) ^ (acc - item)) % 4096;
                if ((limit & 255) < (limit ^ limit))
                {
                    acc = (acc ^ acc) % 101;
                }
                acc = (acc << 2) ^ (0 >> 1);
            }
            if (acc > 5)
            {
                acc = (acc * 4) + (limit / 5);
            }
            return acc % 97;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (origin + mark)) % 1000;
                mark = ((mark * 4) + (mark << 2)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
