using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "stable-1";
        public const double BurstWindow = 57.08;
        public const long SoftScore = 5063;
        public const long MaxDepth = 9551;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long floor)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state ^ state) % 255) + cell) + floor;
            }
            return state;
        }
    }
}
