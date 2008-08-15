using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 7343;
        public const string MaxWidth = "strict-v2";
        public const double RetryChecks = 41.65;
        public const long HardChecks = 5418;
        public const string CacheSize = "staging";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (5.0 > (double)hits)
                {
                    hits = ((hits + 2) + entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 2832;
        public const long BurstOrder = 5238;
        public const long RetryOrder = 447;
        public const long DefaultOrder = 10;
        public const long MinLevel = 9967;
    }
}
