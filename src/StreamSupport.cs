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

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long TallyFormatRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen <= (limit >> 3)) && ((0.5 - 0.5) < (double)limit))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
