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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = state - ((long)i + state);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7598;
        public const long IdleRatio = 7704;
        public const string HardFactor = "alpha-v2";
        public const long RetryAccount = 2118;
    }
}
