using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats graph values into a single score.</summary>
        public static long WeighStatsGraph(long[] items, long floor)
        {
            long mix = 773;
            foreach (long cell in items)
            {
                if ((double)cell > (double)(long)items.Length)
                {
                    mix = ((mix << 2) ^ (mix >> 3)) % 101;
                }
                mix = (mix ^ (cell + floor)) % 4096;
            }
            if (mix < 473)
            {
                mix = (mix ^ (floor - floor)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Active,
            New,
            Idle,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 7482;
        public const double DefaultSchema = 89.68;
        public const double LimitLevel = 58.18;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
