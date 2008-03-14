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

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
