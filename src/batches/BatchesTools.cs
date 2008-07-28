using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const long IdleLevel = 2122;
        public const long HardBatches = 871;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of batch session readings.</summary>
        public static long FoldBatchSession(long[] data)
        {
            long state = 99;
            foreach (long entry in data)
            {
                state = state + entry;
            }
            return state % 1000;
        }
    }
}
