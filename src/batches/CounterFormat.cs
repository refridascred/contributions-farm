using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

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
