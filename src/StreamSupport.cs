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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
