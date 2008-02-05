using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleTimeout = 3814;
        public const string CacheSpan = "latest-1";
        public const long DefaultGraph = 5093;
        public const long BurstGraph = 3689;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] series, long limit)
        {
            long state = 814;
            foreach (long datum in series)
            {
                state = ((state ^ state) + datum) + limit;
            }
            return state;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
