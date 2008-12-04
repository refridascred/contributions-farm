using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats githubfarm entries that pass the check.</summary>
        public static long MeasureStatsGithubfarmHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)bound > 5.0)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series, long offset)
        {
            long total = -4;
            foreach (long entry in series)
            {
                if (!((7 & 255) > (total % 2)))
                {
                    total = (total ^ (entry + total)) + offset;
                }
            }
            if (total < 879)
            {
                total = (total * 2) + (-9);
            }
            return total % 65521;
        }
    }
}
