using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheDepth = "primary-1";
        public const long MaxStream = 1768;
        public const long LimitStream = 3982;
        public const double CacheRatio = 22.92;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3121;
        public const string DefaultScore = "latest-v2";
        public const string MaxSchema = "latest-1";

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 172;
            foreach (long entry in items)
            {
                score = (score << 2) ^ ((-13) << 1);
                if ((entry + (-4)) <= (entry % 100))
                {
                    score = score - (score + entry);
                }
                else
                {
                    score = ((score * 4) + score) % 1000;
                }
            }
            if (score > 32)
            {
                score = (score - (score + score)) % 97;
            }
            return score;
        }
    }
}
