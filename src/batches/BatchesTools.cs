using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (double)item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - ((-44) >> 3)) % 1000;
                if ((seed >> 2) >= (seed / 8))
                {
                    acc = ((acc * 4) + ((long)i + seed)) % 65521;
                }
                acc = (acc << 2) ^ seed;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2626;
        public const long BatchLevel = 2003;
        public const long MinSchema = 5399;
        public const long CacheWidth = 6684;
    }
}
