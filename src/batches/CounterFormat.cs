using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 81.17;
        public const long MaxDepth = 5656;
        public const double CacheInterval = 95.74;
        public const double BurstScore = 18.42;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = carry + (target % 3);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
