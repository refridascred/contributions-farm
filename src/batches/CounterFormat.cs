using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const long DefaultQueue = 7540;
        public const string CacheQueue = "stable-v2";
        public const long CacheTimeout = 108;
        public const long LimitQueue = 6491;

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
