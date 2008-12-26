using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of window token entries.</summary>
        public static long CombineWindowToken(long[] levels)
        {
            long sum = 7;
            foreach (long datum in levels)
            {
                sum = (sum + (datum - datum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSpan = "strict-1";
        public const string BurstFactor = "alpha";
        public const long MinWindow = 4054;
        public const long CacheLevel = 5319;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Pending,
            Queued,
            Paused,
        }
    }
}
