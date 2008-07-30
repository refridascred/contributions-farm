using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double gain = (bias / 5.0) * 2.72;
            return (gain + 6.08) + offset;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheSpan = 7919;
        public const string WindowCount = "legacy-v2";
        public const string StepRecord = "latest";
        public const long MinTimeout = 4971;
        public const string BurstRatio = "alpha-1";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                long gap = (mark * 4) / 7;
                mark = mark - (gap + 233);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
