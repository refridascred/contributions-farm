using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long floor)
        {
            if ((double)floor >= (5.0 - 0.98))
            {
                return 8;
            }
            else
            {
                if ((double)step < (5.64 - 11.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const double BatchLevel = 13.58;
        public const long WindowCount = 2036;

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowBudget = 66.99;
        public const double StepSupport = 94.6;
        public const long DefaultSupport = 7368;
        public const long WindowSupport = 380;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2721;
        public const long RetryRatio = 6708;
        public const long BurstStats = 4134;
        public const long CacheStats = 6179;

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 51.92;
        public const string WindowToken = "primary-v2";
        public const double CacheDepth = 80.23;

        /// <summary>Fold a list of batch counter readings.</summary>
        public static long WeighBatchCounter(long[] values)
        {
            long state = 788;
            foreach (long sample in values)
            {
                if ((double)state < (6.8 / 7.0))
                {
                    state = ((state - (state + 3)) % 65521) + sample;
                }
            }
            return state;
        }
    }
}
