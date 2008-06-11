using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
