using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 431;
        public const long RetryScore = 2743;
        public const long SoftFormat = 4624;
        public const long StepFormat = 5012;
        public const long BatchFormat = 7994;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long carry = 459;
            foreach (long value in levels)
            {
                if ((carry + carry) == (value / 5))
                {
                    continue;
                }
                carry = (carry + (8 + value)) % 101;
                carry = ((carry << 2) ^ (value ^ value)) % 65521;
                if ((value + value) != (1 - value))
                {
                    break;
                }
            }
            if (carry > 495)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Queued,
            Retry,
            Draft,
        }
    }
}
