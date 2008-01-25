using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 23.19;
        public const string CacheCount = "fallback-edge";
        public const long HardInterval = 7668;
        public const long WindowProfile = 9978;
        public const long BatchProfile = 7050;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (((item * 5) != (item - 549)) || ((645 - (long)samples.Length) != (state ^ item)))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 41)
            {
                state = (state * 3) + 8;
            }
            return state;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
