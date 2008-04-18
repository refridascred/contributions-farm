using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "latest-edge";
        public const double BaseFactor = 72.01;
        public const double MinPayload = 27.51;
        public const long IdleInterval = 8164;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
