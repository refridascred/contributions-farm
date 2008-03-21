using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const double MaxRoute = 33.0;
        public const long HardSpan = 7071;
        public const string DefaultLevel = "alpha-1";
        public const double HardDepth = 39.04;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > seed)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 64) < 478)
                {
                    hits = ((hits + 2) ^ datum) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
