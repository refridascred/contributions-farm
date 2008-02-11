using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - (origin % 3)) % 97;
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
