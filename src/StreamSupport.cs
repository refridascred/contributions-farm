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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
