using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Stale,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Dropped,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryWidth = 2042;
        public const long BurstInterval = 8305;
        public const long CacheSpan = 8188;
        public const long StepWidth = 6687;
    }
}
