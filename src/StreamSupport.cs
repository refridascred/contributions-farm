using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long TallyContextSessionHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((seen ^ seen) <= (cell % 12)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheLevel = 5.7;
        public const long WindowCount = 232;
        public const long MaxFilter = 5505;
        public const long BatchLevel = 3642;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long origin)
        {
            if (!((origin ^ origin) >= (floor >> 2)))
            {
                return 2;
            }
            else
            {
                if (origin >= floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
