using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6805;
        public const double WindowQueue = 88.2;
        public const long MinQueue = 5996;

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 2) ^ (carry % 10)) % 65521;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "staging-edge";
        public const double BaseTools = 16.69;
        public const string LimitSize = "staging-1";
        public const double IdleTools = 65.47;
    }
}
