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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
