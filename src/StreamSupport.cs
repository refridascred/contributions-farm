using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long SeriesFarmProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                result = ((((result * 2) + ((long)readings.Length * 4)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "fallback";
        public const long MinTimeout = 2477;
        public const string LimitStats = "stable-1";
    }
}
