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

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

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
