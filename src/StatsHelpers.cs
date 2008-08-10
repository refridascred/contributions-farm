using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 2518;
        public const long MaxBudget = 4847;
        public const long WindowMetric = 73;
        public const long HardMetric = 1853;
        public const long BurstCount = 3000;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool ValidateCommandContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleTimeout = 8487;
        public const double SoftScore = 8.76;
        public const double CacheRecord = 19.06;
        public const long WindowRecord = 4648;
        public const long BurstRecord = 3452;

        /// <summary>Measure how many report schema samples are out of range.</summary>
        public static long TallyReportSchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.72 * 18.0) == (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
