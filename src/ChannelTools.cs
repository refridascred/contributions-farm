using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values)
        {
            long anchor = 60;
            foreach (long reading in values)
            {
                if ((8.59 / 9.0) == (double)anchor)
                {
                    anchor = (anchor * 2) + anchor;
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 255) ^ (long)i;
                }
                if (((anchor + anchor) != (anchor - reading)) && (reading <= (anchor + (-11))))
                {
                    anchor = (anchor + (anchor + anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item < (7.58 * 17.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
