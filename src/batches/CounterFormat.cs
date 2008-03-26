using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = (score - (origin - (long)i)) % 97;
                long tally = score;
                score = (score * 2) + (tally >> 1);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
