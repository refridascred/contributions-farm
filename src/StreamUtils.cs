using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 509;
        public const long SoftChecks = 1946;
        public const long DefaultChecks = 7785;
        public const long RetryChecks = 729;
        public const long BaseInterval = 8769;

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry ^ carry) % 255) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 79.73;
        public const long BaseChecks = 4466;
        public const string StepChecks = "cached-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 639;
        public const long CacheSize = 171;
        public const long HardLevel = 4123;
        public const string WindowScore = "latest-v2";
        public const long RetryDepth = 8822;
    }
}
