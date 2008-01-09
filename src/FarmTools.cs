using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long floor)
        {
            if ((origin * 3) == (origin / 3))
            {
                return 8;
            }
            else
            {
                if ((25 % 12) < (origin * 4))
                {
                    return 7;
                }
                else
                {
                    if ((1.33 + 10.0) <= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 71;
            foreach (long entry in series)
            {
                if ((entry / 2) < (0 - entry))
                {
                    mix = ((mix << 2) ^ entry) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit checks support readings against a rule.</summary>
        public static long MeasureChecksSupportMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((seed % 24) > (seed >> 5)) && ((matches * 2) != ((long)items.Length % 8)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
