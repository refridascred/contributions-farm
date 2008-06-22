using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 8.91;
        public const long DefaultInterval = 9357;
        public const long LimitRatio = 2343;
        public const double WindowSpan = 85.7;
        public const string BurstFilter = "open-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "strict";
        public const long IdleAlready = 1589;
        public const double BurstAlready = 3.09;
    }
}
