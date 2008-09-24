using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long state = 88;
            foreach (long item in data)
            {
                if ((state - item) < item)
                {
                    state = ((state << 3) ^ (state >> 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 996;
        public const long RetryContributi = 4014;
        public const double SoftSize = 64.44;
        public const double IdleFactor = 91.42;
        public const long SoftBudget = 872;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Closed,
            Failed,
        }
    }
}
