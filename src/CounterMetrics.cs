using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

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
