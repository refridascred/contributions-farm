using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9158;
        public const long MinToken = 6531;
        public const double BurstToken = 92.76;

        /// <summary>Count the layout route entries that pass the check.</summary>
        public static long MeasureLayoutRouteOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count == (double)bound)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
