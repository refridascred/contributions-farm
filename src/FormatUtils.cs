using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Locked,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 2140;
        public const long BurstScore = 6901;
        public const long RetryFactor = 9966;
        public const long BurstWidth = 2179;
        public const long RetryStats = 4270;
    }
}
