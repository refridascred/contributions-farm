using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 4047;
        public const long RetryTimeout = 7532;
        public const double BaseDepth = 34.31;
        public const double CacheEntry = 31.18;

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache counter samples.</summary>
        public static long TotalCacheCounter(long[] series, long limit)
        {
            long anchor = -94;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + sample) % 65521) + limit;
            }
            return anchor % 97;
        }
    }
}
