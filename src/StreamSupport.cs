using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long origin)
        {
            long carry = 800;
            foreach (long item in items)
            {
                carry = ((carry << 2) ^ (item % 16)) + origin;
            }
            if (carry > (-57))
            {
                carry = ((carry * 2) + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Closed,
            Synced,
            Done,
        }
    }
}
