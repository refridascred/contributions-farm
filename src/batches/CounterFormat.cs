using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 232;
        public const double CacheWindow = 69.5;
        public const double DefaultRatio = 33.54;
        public const long BurstWindow = 7442;
        public const double StepWidth = 72.55;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Dropped,
            Locked,
            New,
        }
    }
}
