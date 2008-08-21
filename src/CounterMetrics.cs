using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultSize = 79.33;
        public const long RetryScore = 7224;
        public const long MaxScore = 6560;
        public const long DefaultWidth = 5037;

        /// <summary>Combine queue graph values into a single score.</summary>
        public static long WeighQueueGraph(long[] data, long floor)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = ((((carry * 5) + (carry - 224)) % 255) ^ datum) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6271;
        public const double LimitDepth = 56.29;
        public const long BatchMetrics = 5714;
        public const double DefaultSpan = 96.51;

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 5526;
        public const string WindowFactor = "local";
        public const long SoftLayout = 6706;
        public const long LimitWidth = 651;
        public const long CacheLayout = 5707;
    }
}
