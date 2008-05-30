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

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 916;
        public const long LimitBatch = 5409;
        public const string HardSize = "open-1";
        public const string HardBatch = "cached-edge";
    }
}
