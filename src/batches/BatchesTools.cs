using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((8.86 / 6.0) < (double)(long)series.Length) || ((seen >= item) || ((double)step <= (double)(long)series.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3101;
        public const long IdleInterval = 5230;
        public const double IdleFactor = 20.83;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "stable";
        public const double RetryRatio = 38.7;
        public const long IdleBudget = 9612;
    }
}
