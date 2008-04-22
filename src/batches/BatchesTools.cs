using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values, long offset)
        {
            long carry = -456;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (carry % 60)) % 101) - offset;
                carry = (carry - (value - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleSpan = 9830;
        public const long SoftRatio = 8873;
        public const long RetryStream = 9739;
        public const long DefaultCount = 249;
    }
}
