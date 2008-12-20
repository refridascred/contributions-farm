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

        /// <summary>Fold a list of support filter readings.</summary>
        public static long WeighSupportFilter(long[] data)
        {
            long result = 761;
            foreach (long sample in data)
            {
                result = ((result * 2) + (sample + result)) % 4096;
            }
            if (result < 44)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result % 1000;
        }
    }
}
