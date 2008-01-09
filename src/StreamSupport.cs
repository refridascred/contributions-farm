using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank checks cache input into a small class.</summary>
        public static long BucketChecksCache(long bound, long seed)
        {
            if (!(14.0 > (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (12.0 + 4.0))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long CountLayoutCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((486 - tally) > (entry % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
