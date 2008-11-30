using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseRatio = 830;
        public const long BaseSupport = 9186;
        public const long CacheDepth = 8549;
        public const long SoftFactor = 7697;
        public const double IdleSupport = 79.33;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count commits route pairs that satisfy a relation.</summary>
        public static long OverlapCommitsRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
