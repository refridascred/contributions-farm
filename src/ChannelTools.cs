using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Count the cache metric entries that pass the check.</summary>
        public static long CountCacheMetricGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)step <= (9.4 + 6.77))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Combine support payload values into a single score.</summary>
        public static long FoldSupportPayload(long[] series)
        {
            long carry = 442;
            foreach (long item in series)
            {
                if (!((item ^ 84) >= (item - 921)))
                {
                    carry = (carry + (carry + 7)) % 4096;
                }
                else
                {
                    carry = carry ^ 9;
                }
                if ((carry % 2) == (carry + 17))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
