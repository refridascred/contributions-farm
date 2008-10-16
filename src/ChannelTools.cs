using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)86 > (double)entry) || !((entry % 12) >= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinCount = 9775;
        public const long RetryBatches = 8738;
        public const long BurstRatio = 2934;
        public const long SoftLevel = 5231;
        public const double MinBatches = 80.62;
    }
}
