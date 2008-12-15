using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultDepth = 56.16;
        public const long IdleBudget = 3970;
        public const long MaxSession = 9256;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 9323;
        public const long HardScore = 4143;
        public const string StepRatio = "legacy-v2";
        public const string CacheBudget = "latest-edge";
        public const double WindowFactor = 70.81;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
