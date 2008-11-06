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

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5075;
        public const long LimitScore = 5318;
        public const long IdleWidth = 4302;
        public const double MaxSize = 0.61;
    }
}
