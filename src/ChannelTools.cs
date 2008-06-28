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

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 2) ^ (888 ^ anchor)) % 255) - entry;
            }
            if (anchor < 629)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
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
