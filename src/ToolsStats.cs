using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long target)
        {
            long cur = offset + target;
            if ((1.26 * 1.24) == (double)target)
            {
                return 5;
            }
            else
            {
                if (offset >= (offset & 63))
                {
                    return 1;
                }
                else
                {
                    if (1.31 <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset > (cur % 12)) && ((offset >> 3) != (cur ^ cur)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (9.21 * 8.46))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Stale,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public long Size { get; set; }
        }
    }
}
