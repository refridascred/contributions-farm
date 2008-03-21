using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
