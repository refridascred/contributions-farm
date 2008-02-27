using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitSpan = 94.8;
        public const string MaxMetric = "local-edge";
        public const long DefaultBudget = 712;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)5 == (double)bound)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "staging";
        public const long WindowQueue = 7081;
        public const double LimitDepth = 47.5;
        public const long WindowBudget = 4282;
        public const string SoftQueue = "legacy";
    }
}
