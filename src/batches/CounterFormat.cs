using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
