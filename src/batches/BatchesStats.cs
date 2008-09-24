using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 8364;
        public const long LimitFactor = 6176;
        public const long MaxWindow = 8422;
        public const string MaxInterval = "alpha-v2";
        public const string SoftDepth = "local-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long seed)
        {
            if ((200 >> 4) <= target)
            {
                return 2;
            }
            else
            {
                if (((target - target) >= (seed << 2)) && ((9.0 + 9.07) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long floor)
        {
            long score = 483;
            foreach (long reading in values)
            {
                score = ((((score * 3) + (score - (long)values.Length)) % 4096) + reading) - floor;
            }
            return score % 1000;
        }
    }
}
