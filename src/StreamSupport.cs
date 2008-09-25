using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Count metrics stats pairs that satisfy a relation.</summary>
        public static long CompareMetricsStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 4444;
        public const long RetryPayload = 9907;
        public const long BasePayload = 4899;
    }
}
