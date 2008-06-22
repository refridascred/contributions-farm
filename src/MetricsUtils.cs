using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many account route samples are out of range.</summary>
        public static long AuditAccountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(matches > 6) || ((double)matches <= (15.0 + 8.4)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
