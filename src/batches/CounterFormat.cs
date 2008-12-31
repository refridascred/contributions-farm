using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 7200;
        public const double BurstDepth = 54.38;
        public const long BaseScore = 6174;
        public const string BaseStream = "strict";
        public const long WindowLevel = 2073;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor ^ (long)i;
                anchor = (anchor - anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
