using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((7.6 * 5.4) > (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
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
