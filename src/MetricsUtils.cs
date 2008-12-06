using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSize = "legacy-1";
        public const long SoftBatch = 2489;
        public const long RetryBatch = 1555;
        public const double CacheBatch = 71.5;
        public const long CacheScore = 5170;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long MeasureChecksLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell <= (seen + cell)) || ((seen & 255) >= seen)) || ((cell - cell) <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum + (long)levels.Length) < (70 - datum))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
