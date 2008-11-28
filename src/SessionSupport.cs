using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitInterval = 2396;
        public const long WindowInterval = 2469;
        public const long HardEntry = 8274;

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long StepToolsSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (target ^ carry)) % 101;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8781;
        public const long StepWidth = 7196;
        public const long WindowToken = 8698;
        public const double LimitToken = 42.66;
    }
}
