using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 964;
        public const long RetryFactor = 6916;
        public const long WindowInterval = 6016;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 6921;
        public const string MinEntry = "local";
        public const long CacheEntry = 6739;
        public const double RetryLevel = 79.26;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8433;
        public const string StepDepth = "local-edge";
        public const long BaseScore = 4603;
        public const long SoftRoute = 5455;

        /// <summary>Compare every pair of context editor readings.</summary>
        public static long OverlapContextEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
