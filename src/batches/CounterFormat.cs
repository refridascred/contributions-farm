using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleDepth = 7245;
        public const string SoftPayload = "staging-edge";
        public const long IdlePayload = 2598;
        public const long StepCount = 4336;
        public const double CacheWidth = 65.1;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultDepth = "primary-1";
        public const double DefaultWidth = 91.29;
        public const long SoftBudget = 827;
        public const double MinCount = 20.35;
    }
}
