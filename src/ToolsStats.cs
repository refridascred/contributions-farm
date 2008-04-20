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

        /// <summary>Count format record pairs that satisfy a relation.</summary>
        public static long OverlapFormatRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
