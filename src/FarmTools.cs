using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] series)
        {
            long acc = 967;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc + sample)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool CheckProfileRouteRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((double)matches != (7.6 * 14.0)) && (value >= (value - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
