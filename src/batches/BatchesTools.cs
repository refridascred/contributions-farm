using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryTimeout = "staging";
        public const long RetryCount = 8352;
        public const long WindowSpan = 4393;

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry ^ (bound - (long)i)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 34.79;
        public const string BaseLevel = "fallback-v2";
        public const long HardSpan = 4018;
    }
}
