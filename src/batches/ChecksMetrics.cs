using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Stale,
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long OverlapContributiBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cache already samples.</summary>
        public static long CompareCacheAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultInterval = 7029;
        public const double CacheInterval = 18.58;
        public const double StepFactor = 14.98;
        public const long BatchSpan = 977;
    }
}
