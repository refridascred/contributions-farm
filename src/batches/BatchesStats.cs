using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long floor2)
        {
            if (floor <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((9 - floor) != (floor / 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepTimeout = "standard";
        public const long MaxScore = 6105;
        public const double RetrySpan = 84.82;
        public const long DefaultSpan = 7983;
        public const string LimitScore = "local-edge";

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values, long target)
        {
            long acc = 856;
            foreach (long datum in values)
            {
                acc = ((acc - (5 & 15)) ^ datum) + target;
            }
            if (acc > 527)
            {
                acc = acc ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
