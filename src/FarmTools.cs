using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstSpan = "cached-edge";
        public const double CacheDepth = 33.25;
        public const string CacheAccount = "strict-edge";

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
