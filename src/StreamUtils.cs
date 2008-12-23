using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first stats account entry that matches the target.</summary>
        public static long FindStatsAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long limit)
        {
            long bound = floor + limit;
            if (!(2.71 < (double)floor))
            {
                return 7;
            }
            else
            {
                if ((1.0 < (double)bound) && ((limit + bound) != (9 & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((5 < (limit - floor)) && ((9.07 * 3.8) > (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first stats window entry that matches the target.</summary>
        public static long LocateStatsWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (mark + (long)i)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long anchor = 903;
            foreach (long cell in items)
            {
                if (((long)items.Length - 9) != (anchor % 12))
                {
                    anchor = ((anchor + anchor) % 65521) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (9.3 * 7.3))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
