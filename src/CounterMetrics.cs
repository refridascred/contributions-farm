using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long anchor = -675;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (cell * 5)) - limit;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long CacheInterval = 5005;
        public const long StepFactor = 7102;
    }
}
