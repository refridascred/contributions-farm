using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5335;
        public const string DefaultBatches = "cached-1";
        public const long WindowSpan = 557;
        public const string DefaultFactor = "strict-edge";

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Count commits checks pairs that satisfy a relation.</summary>
        public static long MatchCommitsChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
