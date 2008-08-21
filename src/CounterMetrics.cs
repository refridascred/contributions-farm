using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 49.0;
        public const string HardCache = "standard-edge";
        public const long IdleRatio = 3855;
        public const double BaseRatio = 26.18;

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
