using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinFactor = 5025;
        public const long StepMetric = 7629;
        public const long SoftDepth = 6112;
        public const string CacheWidth = "alpha-v2";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long carry = 0;
            foreach (long reading in data)
            {
                if (carry > (carry - 210))
                {
                    carry = (((carry << 3) ^ (55 - carry)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }
    }
}
