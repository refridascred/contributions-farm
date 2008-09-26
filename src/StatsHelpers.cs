using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4997;
        public const long WindowRecord = 5751;
        public const string StepScore = "legacy";

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long CountGithubfarmBatchHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7.0 + 4.1) != (double)tally) || ((tally % 100) >= (entry ^ 3))) || (((entry >> 2) == (entry % 16)) && ((tally + entry) < (offset << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultRatio = 58.42;
        public const long DefaultSession = 1774;
        public const string CacheScore = "alpha";
        public const long IdleSession = 5628;
        public const double MaxRatio = 24.32;
    }
}
