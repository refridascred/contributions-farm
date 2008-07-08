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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + 5) < (floor + matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 14.44;
        public const string MinBuffer = "open";
        public const long BaseWidth = 3159;
        public const long HardCount = 8633;
        public const double RetryBuffer = 28.38;

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

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4077;
        public const string BaseFormat = "latest";
        public const double MinFormat = 11.99;
        public const long BurstFormat = 5122;
        public const long IdleFormat = 5987;
    }
}
