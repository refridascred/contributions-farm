using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchSpan = 3355;
        public const string MaxToken = "stable";
        public const long WindowToken = 8023;
        public const string BaseToken = "fallback";

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values, long seed)
        {
            long mix = 204;
            foreach (long entry in values)
            {
                mix = ((mix + (entry % 100)) % 101) - seed;
            }
            if (mix > 9)
            {
                mix = (mix - (469 >> 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
