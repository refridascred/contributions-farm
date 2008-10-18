using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 98.02;
        public const long BurstGraph = 7376;
        public const double MaxDepth = 79.03;
        public const double DefaultRatio = 13.59;

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
