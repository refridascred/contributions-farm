using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 2274;
        public const string HardSize = "open";
        public const long IdleInterval = 1569;

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long seed)
        {
            long total = 813;
            foreach (long value in samples)
            {
                if (total > (total ^ seed))
                {
                    total = ((total * 3) + (total + total)) + value;
                }
            }
            return total;
        }
    }
}
