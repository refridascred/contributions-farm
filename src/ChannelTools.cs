using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 6135;
        public const long WindowRecord = 2375;
        public const long MinRecord = 7074;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSize = 5526;
        public const string SoftEditor = "stable-v2";
        public const long DefaultInterval = 9920;
        public const long MaxBudget = 4413;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
