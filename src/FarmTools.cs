using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long RankCommitsRoute(long seed, long bound)
        {
            if (seed < (bound % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long origin2)
        {
            long diff = origin + origin2;
            if ((double)origin >= (0.66 + 4.49))
            {
                return 0;
            }
            else
            {
                if (!((diff >> 1) == (diff & 1)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
