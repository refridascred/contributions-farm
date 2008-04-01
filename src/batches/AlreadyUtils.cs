using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long SortMetricsMetric(long origin, long seed)
        {
            if ((origin >= (seed * 2)) && ((double)seed < (double)1))
            {
                return 4;
            }
            else
            {
                if ((origin + 30) < (673 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if ((825 % 64) <= (origin << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((45 ^ seed) <= (seed ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Pending,
        }
    }
}
