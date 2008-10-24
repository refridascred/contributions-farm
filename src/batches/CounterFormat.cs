using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 525;
        public const string SoftBatch = "standard-edge";
        public const long SoftTimeout = 1289;
        public const string LimitSize = "strict";
        public const long LimitFactor = 6815;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if ((40 ^ step) != (step & 63))
            {
                return 5;
            }
            else
            {
                if ((bound / 2) < (origin & 7))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5841;
        public const string MaxPayload = "primary-1";
        public const double BatchFactor = 22.92;
        public const string WindowDepth = "legacy";
        public const string RetryPayload = "fallback-v2";
    }
}
