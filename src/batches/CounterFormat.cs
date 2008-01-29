using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheWidth = 35.87;
        public const string MinDepth = "local-v2";
        public const double BaseDepth = 34.49;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "cached-1";
        public const long BatchDepth = 8974;
        public const long IdleWidth = 2894;

        /// <summary>Compare every pair of schema metrics readings.</summary>
        public static long CompareSchemaMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
