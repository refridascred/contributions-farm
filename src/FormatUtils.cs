using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((matches * 4) < 5) || ((item % 97) > (item & 255))) || ((double)matches != (double)item))
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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((bound - bound) > (count % 16)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + seen) > 74)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Queued,
            Draft,
            New,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
