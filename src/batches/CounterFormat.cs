using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6884;
        public const long LimitBudget = 3474;
        public const long StepScore = 6480;
        public const string RetryContext = "staging-edge";
        public const long StepDepth = 1010;

        /// <summary>Roll a command batch counter forward.</summary>
        public static long IterateCommandBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5075;
        public const long LimitScore = 5318;
        public const long IdleWidth = 4302;
        public const double MaxSize = 0.61;
    }
}
