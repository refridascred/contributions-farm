using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardRatio = 97.51;
        public const long CacheCluster = 3398;
        public const long CacheWidth = 7531;

        /// <summary>Count schema metric pairs that satisfy a relation.</summary>
        public static long PairSchemaMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
