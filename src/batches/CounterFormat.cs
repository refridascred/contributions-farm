using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long AuditStatsAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (306 ^ matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches + matches) <= matches) && ((matches * 4) <= (50 - matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
