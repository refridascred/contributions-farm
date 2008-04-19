using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSize = 4.13;
        public const long IdleSupport = 2164;
        public const double IdleTimeout = 64.22;
        public const long WindowSupport = 6857;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (9.02 < (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
