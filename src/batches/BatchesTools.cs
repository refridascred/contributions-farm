using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the profile entry entries that pass the check.</summary>
        public static long MeasureProfileEntryGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(4.8 < (double)item))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long carry = 4;
            foreach (long datum in levels)
            {
                carry = ((carry ^ (43 << 1)) % 255) ^ datum;
            }
            if (carry > (-46))
            {
                carry = carry ^ (carry & 127);
            }
            return carry % 1000;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((double)gap < (5.9 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 98) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (seed > (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
