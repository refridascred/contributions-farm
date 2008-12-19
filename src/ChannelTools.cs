using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches % 97) < 18) && ((matches + matches) != (cell >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (8.3 * 7.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long AuditAccountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(7 < count))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
