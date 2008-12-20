using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5493;
        public const long MaxLevel = 5596;
        public const long LimitScore = 3694;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
