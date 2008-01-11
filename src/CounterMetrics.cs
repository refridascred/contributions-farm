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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1718;
        public const long BurstContributi = 6712;
        public const long WindowBudget = 9037;
        public const long MinTimeout = 3110;

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
