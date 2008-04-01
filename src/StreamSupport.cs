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

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = (total - (item + item)) % 4096;
            }
            if (total < 47)
            {
                total = total - total;
            }
            return total;
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
