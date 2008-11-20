using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format order readings against a rule.</summary>
        public static long MeasureFormatOrderGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value * 3) > matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every command payload entry stays within the limit.</summary>
        public static bool GuardCommandPayloadLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5144;
        public const long RetryDepth = 7131;
        public const string BaseSize = "strict";
        public const string BaseFilter = "cached-1";
        public const long BurstInterval = 3768;

        /// <summary>Count the account token entries that pass the check.</summary>
        public static long MeasureAccountTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits < (hits + (-274))) && ((hits * 3) >= (item * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
