using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

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
