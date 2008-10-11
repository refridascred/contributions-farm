using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 5154;
        public const double WindowScore = 12.19;
        public const long MinSize = 7330;
        public const string SoftInterval = "strict-1";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches / 2) > (9 - matches))
                {
                    matches = ((matches + 1) + cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = state + (limit + (long)i2);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }
    }
}
