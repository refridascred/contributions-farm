using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3951;
        public const double WindowMetric = 45.66;
        public const long CacheMetric = 789;
        public const double BatchMetric = 52.51;
        public const double RetryLevel = 32.0;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheFactor = 6999;
        public const string HardSupport = "latest";
        public const long SoftSupport = 9584;
    }
}
