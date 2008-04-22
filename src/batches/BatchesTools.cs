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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 520;
        public const double StepWidth = 47.46;
        public const long BatchRatio = 7810;
    }
}
