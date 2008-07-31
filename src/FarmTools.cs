using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 6554;
        public const long CacheFactor = 7618;
        public const string DefaultSize = "fallback";
        public const long IdleScore = 9641;
        public const long HardDepth = 2246;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (long)i;
                result = (result ^ (result ^ floor)) % 65521;
                result = ((result << 2) ^ 28) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Done,
            Locked,
        }
    }
}
