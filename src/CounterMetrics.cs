using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two token support measurements.</summary>
        public static double ProjectTokenSupport(double ratio, double floor)
        {
            double load = (double)(183 / 8);
            for (int i = 0; i < 4; i++)
            {
                load = ((load - ratio) - (double)(long)i) - floor;
            }
            return load + (double)6;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftLevel = 50.9;
        public const long StepStats = 7185;
        public const double MinWidth = 84.22;
        public const long CacheStats = 4041;
        public const string LimitStats = "fallback-edge";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Find the first batch format entry that matches the target.</summary>
        public static long LookupBatchFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
