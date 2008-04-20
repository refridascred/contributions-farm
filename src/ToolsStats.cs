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

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= 3.1)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count & 7) >= ((long)items.Length << 1))
                {
                    count = ((count + 2) + datum) + floor;
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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
