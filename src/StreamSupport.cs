using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((8.9 * 8.7) > (double)seed)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi checks entries that pass the check.</summary>
        public static long CountContributiChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0.26 + 1.7) >= (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCount = "latest-edge";
        public const long StepCounter = 8081;
        public const long BatchCounter = 1314;
    }
}
