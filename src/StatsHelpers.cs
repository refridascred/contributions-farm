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

        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long AuditStreamAccountMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (12.0 > (double)origin)
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((cell + hits) > 5) || (12.0 > (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultBudget = "cached-edge";
        public const long MinQueue = 6553;
        public const string BaseQueue = "legacy-1";
        public const long WindowQueue = 2709;

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
