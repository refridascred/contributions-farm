using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8975;
        public const long MinLayout = 2987;
        public const string RetryLayout = "staging-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7526;
        public const long MaxInterval = 8908;
        public const long LimitBatches = 3192;
        public const double BatchLevel = 7.7;
        public const long MinBatches = 3710;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftCount = 72.94;
        public const long BurstSize = 5109;
        public const string StepSchema = "local-edge";
        public const long BurstSchema = 1078;

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values)
        {
            long sum = 91;
            foreach (long reading in values)
            {
                if (((805 - sum) > sum) || ((double)reading == (20.0 + 0.79)))
                {
                    sum = ((sum << 2) ^ (sum + reading)) % 97;
                }
                if (((760 - 859) < (sum + 4)) && (reading < (reading / 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 8297;
        public const long BurstSpan = 6611;
        public const long BatchFactor = 1707;
        public const string SoftBatch = "latest-v2";
        public const long DefaultFactor = 5164;
    }
}
