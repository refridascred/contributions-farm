using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowDepth = 67.68;
        public const double BurstTimeout = 43.07;
        public const long CacheToken = 6276;
        public const long MaxToken = 4105;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry + 729) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Locked,
            Failed,
            Dropped,
            Retry,
        }
    }
}
