using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 7163;
        public const long IdleChannel = 3478;
        public const long MaxBudget = 5693;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry ^ (carry / 6)) % 4096;
                carry = (carry ^ carry) % 1000;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardLevel = 5756;
        public const long StepInterval = 8020;
        public const long StepNotes = 2263;
        public const long BaseBudget = 4102;
    }
}
