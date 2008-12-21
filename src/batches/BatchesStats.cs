using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryScore = 41.94;
        public const double BatchFactor = 71.05;
        public const long RetryAccount = 1429;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long sum = 56;
            foreach (long datum in levels)
            {
                sum = sum + (sum + datum);
            }
            if (sum > 741)
            {
                sum = (sum + (6 ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinRatio = "legacy-1";
        public const string IdleAccount = "latest-v2";
        public const long LimitFactor = 2882;
    }
}
