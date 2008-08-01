using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry * 4) < count) || ((double)count != (12.0 * 3.7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = (double)103;
            return ((bias + bias) + weight) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long BatchGithubfarm = 5539;
        public const string BaseGithubfarm = "stable-edge";
        public const long WindowCount = 8473;
        public const string MinGithubfarm = "primary-v2";
    }
}
