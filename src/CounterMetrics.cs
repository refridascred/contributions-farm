using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a cache context reading by value.</summary>
        public static long LookupCacheContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardTimeout = 7722;
        public const long MinRecord = 8485;
        public const long WindowBudget = 710;
        public const long BaseSize = 7565;
        public const long BurstBudget = 1068;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Queued,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
