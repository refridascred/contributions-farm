using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 4405;
        public const string RetryLevel = "stable-v2";
        public const double StepWidth = 36.45;
    }
}
