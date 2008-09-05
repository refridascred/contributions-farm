using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleTimeout = "staging-v2";
        public const string CacheBudget = "alpha-edge";
        public const long IdleGithubfarm = 4217;
        public const long BatchWidth = 7330;
        public const long BaseGithubfarm = 6391;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
