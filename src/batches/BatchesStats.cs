using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank contributi githubfarm input into a small class.</summary>
        public static long ClassifyContributiGithubfarm(long bound, long floor)
        {
            if (floor > (floor - (-5)))
            {
                return 6;
            }
            else
            {
                if (((floor ^ bound) < (189 ^ bound)) && ((bound % 97) >= (bound >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Failed,
            Active,
            Done,
            Locked,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
