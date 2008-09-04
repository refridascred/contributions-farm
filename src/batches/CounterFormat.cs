using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                if ((mix + 603) >= ((-24) + 1))
                {
                    mix = (((mix * 5) + (mix + 8)) % 1000) ^ datum;
                }
            }
            if (mix > 126)
            {
                mix = ((mix * 3) + (mix % 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long TallyAlreadyStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length >= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchDepth = 7017;
        public const long CacheLevel = 1825;
        public const long BatchRecord = 8277;
        public const double CacheTimeout = 44.47;
        public const long MinRecord = 1672;
    }
}
