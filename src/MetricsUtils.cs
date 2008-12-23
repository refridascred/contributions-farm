using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "fallback-edge";
        public const long LimitCache = 1436;
        public const string MaxRatio = "strict";
        public const long DefaultCache = 8224;
        public const long BaseLevel = 1096;

        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long SeriesBufferGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 2) ^ (6 - mark)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 2987;
        public const long BurstOrder = 8170;
        public const long IdleSize = 9011;
        public const string BaseOrder = "strict-v2";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
