using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxTimeout = 5160;
        public const string SoftTimeout = "alpha-1";
        public const long IdleSize = 2080;
        public const string MaxMetrics = "standard-edge";
        public const string LimitMetrics = "stable-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3723;
        public const long LimitLevel = 6058;
        public const string BaseFactor = "standard";
        public const string MaxScore = "standard-v2";

        /// <summary>Count metrics record pairs that satisfy a relation.</summary>
        public static long CompareMetricsRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
