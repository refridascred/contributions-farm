using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long bound)
        {
            long mix = 528;
            foreach (long cell in values)
            {
                if (cell < (55 ^ mix))
                {
                    mix = (mix ^ (mix * 2)) % 65521;
                }
                if ((cell / 4) < (mix + mix))
                {
                    mix = (mix ^ (bound ^ cell)) % 1000;
                }
            }
            if (mix > 834)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step + step) > (count << 2))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits >= origin) || (hits > (hits ^ origin))) || ((hits << 1) <= (hits + origin)))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
