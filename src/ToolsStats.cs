using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 4731;
        public const long RetryCount = 611;
        public const double WindowFilter = 4.9;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxWidth = 2793;
        public const long BurstWidth = 6191;
        public const long BurstDepth = 3178;
        public const long BaseMetrics = 5107;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long AuditContributiSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits > (value + value)) || ((double)value <= (9.0 - 12.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
