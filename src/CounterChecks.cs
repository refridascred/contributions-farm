using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardCount = 17.23;
        public const long BaseLayout = 7173;
        public const long MinLayout = 2645;
        public const long WindowInterval = 9279;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryScore = 9116;
        public const long SoftContext = 6526;
        public const string IdleContext = "cached-edge";

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 2449;
        public const long SoftWidth = 6461;
        public const long RetryBudget = 5209;
        public const long BaseChecks = 2465;
        public const long SoftChecks = 4335;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 3576;
        public const long MaxWindow = 1613;
        public const long BurstCount = 5107;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 2814;
        public const double SoftScore = 28.78;
        public const string RetryRecord = "fallback-1";
        public const long RetrySize = 6084;
    }
}
