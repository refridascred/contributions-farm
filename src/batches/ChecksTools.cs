using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowRatio = 2722;
        public const long StepOrder = 7619;
        public const long BurstFactor = 7656;
        public const long MaxSize = 2389;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 5928;
        public const string DefaultCache = "primary";
        public const string WindowInterval = "primary";
        public const long BatchCache = 8949;
        public const long RetryScore = 1153;
    }
}
