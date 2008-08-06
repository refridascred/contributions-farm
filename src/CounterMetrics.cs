using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheSize = "strict-1";
        public const string BatchRecord = "primary-1";
        public const double IdleRecord = 31.62;
        public const double StepRecord = 34.49;

        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double weight, double floor)
        {
            double load = (double)(9 - (-197));
            return ((load + load) + weight) + floor;
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
