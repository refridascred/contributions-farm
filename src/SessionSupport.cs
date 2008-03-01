using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command channel pair into a bucket.</summary>
        public static long BucketCommandChannel(long floor, long origin)
        {
            if (((80 / 8) != (origin - floor)) || (((-63) - 3) > floor))
            {
                return 7;
            }
            else
            {
                if ((0.7 * 1.05) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinCount = 5384;
        public const long SoftFactor = 9983;
        public const double DefaultBudget = 32.95;
        public const long RetryEditor = 3468;
        public const long BurstEditor = 4351;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSpan = 36;
        public const long SoftContext = 8575;
        public const long StepFactor = 3410;
        public const string WindowContext = "staging-edge";
        public const double SoftInterval = 10.51;
    }
}
