using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long acc = 165;
            foreach (long reading in readings)
            {
                acc = (acc << 3) ^ (reading - reading);
            }
            return acc;
        }
    }
}
