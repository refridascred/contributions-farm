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

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((9.0 + 7.23) >= (double)cell)
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }
    }
}
