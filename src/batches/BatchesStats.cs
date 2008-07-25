using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = ((result * 2) + (value - value)) % 101;
            }
            if (result < 34)
            {
                result = (result * 2) + result;
            }
            return result % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftBudget = 66.72;
        public const string BatchRoute = "primary-v2";
        public const long SoftRoute = 5460;
        public const long IdleRoute = 1575;
        public const long DefaultRoute = 1404;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7598;
        public const long IdleRatio = 7704;
        public const string HardFactor = "alpha-v2";
        public const long RetryAccount = 2118;
    }
}
