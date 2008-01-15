using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleSpan = 492;
        public const long IdleBatches = 8173;
        public const long StepBatches = 2791;

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstCount = 8039;
        public const long RetryFarm = 3540;
        public const long CacheSpan = 3676;
        public const string HardInterval = "latest";
        public const string IdleFarm = "staging-1";
    }
}
