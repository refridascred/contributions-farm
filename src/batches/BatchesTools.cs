using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((double)floor > 7.4)
                {
                    acc = ((acc << 2) ^ ((long)i - acc)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long TallyAccountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((4.6 + 2.0) == (double)seen) || ((8.0 + 1.98) != (double)seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7289;
        public const string MinQueue = "primary-edge";
        public const long CacheQueue = 7470;
        public const string CacheSize = "open-v2";
    }
}
