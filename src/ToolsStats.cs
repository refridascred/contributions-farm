using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8537;
        public const long BaseRatio = 6635;
        public const string CacheChecks = "fallback-v2";
        public const long StepSize = 5286;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Idle,
            Draft,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Count counter report pairs that satisfy a relation.</summary>
        public static long MatchCounterReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
