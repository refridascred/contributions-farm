using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "cached-v2";
        public const string DefaultToken = "primary-1";
        public const long SoftToken = 3863;
        public const string BatchToken = "standard";
        public const double HardTimeout = 31.02;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (seed > (7 >> 1))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
