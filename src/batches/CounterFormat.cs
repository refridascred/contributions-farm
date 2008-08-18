using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 2) ^ (target ^ carry);
                carry = (carry * 2) + (target >> 4);
                carry = (carry + (target ^ (long)i)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 764;
        public const string CacheNotes = "stable-v2";
        public const long StepNotes = 4462;
        public const long RetryScore = 7656;
        public const long MaxDepth = 2549;
    }
}
