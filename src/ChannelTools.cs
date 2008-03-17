using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 16.95;
        public const long RetrySpan = 1295;
        public const double HardBudget = 32.84;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
