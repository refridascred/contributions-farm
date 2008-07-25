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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            New,
            Active,
            Pending,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long seed)
        {
            if ((target << 2) < (seed % 3))
            {
                return 0;
            }
            else
            {
                if (((double)target == (7.7 / 9.0)) && ((double)seed != (double)2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7598;
        public const long IdleRatio = 7704;
        public const string HardFactor = "alpha-v2";
        public const long RetryAccount = 2118;
    }
}
