using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 5537;
        public const long MinAccount = 2142;
        public const long BurstAccount = 5478;
        public const string CacheAccount = "local-v2";
        public const long LimitScore = 7639;

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long TallyGraphBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen < (20.0 - 3.9))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
