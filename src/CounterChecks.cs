using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5759;
        public const string BurstBuffer = "legacy-1";
        public const long LimitBuffer = 2459;
        public const double BatchFactor = 7.95;

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long TallyRouteFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((double)tally == (double)datum) && ((tally % 12) != (datum / 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            New,
            Dropped,
        }
    }
}
