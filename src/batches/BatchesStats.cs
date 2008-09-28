using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSize = 9723;
        public const double RetryInterval = 48.91;
        public const long DefaultChecks = 762;
        public const double CacheLevel = 5.49;
        public const double MinChecks = 81.01;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 1876;
        public const long BurstWindow = 2038;
        public const long IdleWindow = 6555;
        public const double DefaultRatio = 89.29;
    }
}
