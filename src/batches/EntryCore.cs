using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 2590;
        public const long BurstCount = 9327;
        public const string RetryFactor = "fallback-edge";
        public const double MaxBatches = 8.93;
        public const long CacheBatches = 1141;

        /// <summary>Project the next layout metrics value.</summary>
        public static double BlendLayoutMetrics(double gain, double floor)
        {
            double drift = floor + gain;
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
