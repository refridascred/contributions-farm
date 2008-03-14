using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "primary";
        public const double CacheDepth = 1.71;
        public const double StepScore = 94.96;
        public const double RetryRatio = 39.68;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
