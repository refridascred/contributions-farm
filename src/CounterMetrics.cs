using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "latest-1";
        public const string MinLevel = "standard-edge";
        public const long DefaultScore = 7356;
        public const string WindowTimeout = "standard-v2";
        public const long SoftRatio = 6175;

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
