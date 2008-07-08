using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinScore = 10.23;
        public const long HardDepth = 6071;
        public const long BaseRatio = 2603;
        public const long CacheBudget = 716;
        public const long MinCache = 3173;

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = 402;
            foreach (long value in samples)
            {
                carry = (carry - value) % 97;
                carry = (carry << 3) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Pending,
            Active,
        }
    }
}
