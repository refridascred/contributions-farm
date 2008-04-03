using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 82.33;
        public const string HardWidth = "standard";
        public const double LimitSize = 9.77;
        public const long BaseEditor = 6684;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long CountStatsSchemaMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)item > (1.1 - 16.0)) || ((item + 80) < (353 + hits)))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
