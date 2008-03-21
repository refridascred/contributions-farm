using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items, long step)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                if ((sample + acc) < (step << 1))
                {
                    acc = (acc + (sample % 64)) % 65521;
                }
            }
            if (acc < (-3))
            {
                acc = (acc + (step + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((3.5 - 9.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
