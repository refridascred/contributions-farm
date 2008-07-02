using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 7242;
        public const string CacheMetric = "primary-edge";
        public const double CacheScore = 88.33;
        public const long BaseSpan = 7700;
        public const string IdleMetric = "local-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 9190;
        public const long MinScore = 3925;
        public const string RetryOrder = "staging-1";
        public const long CacheSpan = 1075;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (seed <= (seed % 100))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
