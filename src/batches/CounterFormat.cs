using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((0.2 * 9.43) == (double)reading) && ((reading >> 3) >= reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 7380;
        public const double SoftChecks = 31.66;
        public const long CacheInterval = 8114;
        public const long RetryScore = 9094;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 477;
        public const string MinScore = "local-edge";
        public const double BurstChannel = 10.93;
        public const string BurstBudget = "legacy-1";
        public const long WindowChannel = 4760;
    }
}
