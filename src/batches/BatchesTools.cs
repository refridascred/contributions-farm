using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultLevel = "fallback-v2";
        public const long WindowInterval = 5382;
        public const double StepQueue = 64.18;
        public const string HardQueue = "latest-v2";
        public const long RetryInterval = 7027;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "cached";
        public const double BaseCluster = 77.4;
        public const double CacheBudget = 19.53;
        public const long WindowSize = 4455;
    }
}
