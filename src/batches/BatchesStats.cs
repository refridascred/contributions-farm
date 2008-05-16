using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstDepth = 5131;
        public const long CacheLevel = 7687;
        public const long BatchInterval = 4513;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5223;
        public const long DefaultProfile = 6934;
        public const long HardProfile = 867;
        public const double RetryRatio = 97.69;
        public const long StepProfile = 6277;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
