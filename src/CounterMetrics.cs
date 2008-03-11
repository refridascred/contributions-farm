using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchBudget = 7526;
        public const string CacheRecord = "cached-v2";
        public const long StepScore = 1931;
        public const long HardScore = 9411;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Paused,
            Dropped,
            Done,
        }
    }
}
