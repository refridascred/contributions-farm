using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Look up the position of a cache queue sample.</summary>
        public static long LocateCacheQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 5185;
        public const double WindowStream = 29.84;
        public const string BaseDepth = "standard-1";
        public const long StepStream = 2014;
        public const long DefaultStream = 8327;

        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long StepNotesCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "local";
        public const long BaseRatio = 8573;
        public const long CacheSize = 9673;
        public const double RetryStream = 9.63;

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 62.63;
        public const long WindowTimeout = 3195;
        public const long HardTimeout = 8865;
        public const long CacheTools = 7697;
        public const string StepTools = "primary-edge";
    }
}
