using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 4398;
        public const long CacheScore = 2468;
        public const long MinInterval = 4080;
        public const long WindowFactor = 8842;
        public const string MaxFactor = "strict-edge";

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Ready,
            Idle,
            Closed,
            Dropped,
        }
    }
}
