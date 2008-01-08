using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of checks payload entries.</summary>
        public static long TallyChecksPayload(long[] levels, long step)
        {
            long carry = 221;
            foreach (long entry in levels)
            {
                if ((1 + entry) < (step ^ entry))
                {
                    carry = ((carry * 5) + (entry >> 2)) % 97;
                }
                if (!((16.0 + 7.0) <= (double)entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 4) < 484)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every context token entry stays within the limit.</summary>
        public static bool VerifyContextTokenRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
