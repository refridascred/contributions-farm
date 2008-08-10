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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits <= 2)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
