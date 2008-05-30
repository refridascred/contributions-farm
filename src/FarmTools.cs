using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length > (cell - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
