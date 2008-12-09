using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "staging-v2";
        public const long RetryCluster = 530;
        public const long BurstFactor = 6485;
        public const double MinCluster = 2.67;
        public const long SoftSize = 142;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long offset)
        {
            long score = -84;
            foreach (long datum in values)
            {
                if ((datum % 8) >= offset)
                {
                    score = ((score << 2) ^ (datum * 5)) % 255;
                }
            }
            return score;
        }
    }
}
