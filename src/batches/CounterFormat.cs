using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) < (cell << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 97.99;
        public const long IdleDepth = 3331;
        public const long CacheScore = 8939;
        public const long IdleEditor = 5330;
        public const long BatchSize = 9184;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
