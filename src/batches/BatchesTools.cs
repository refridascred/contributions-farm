using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5249;
        public const long BaseSpan = 8270;
        public const string CacheScore = "staging-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 580;
        public const long HardRatio = 9359;
        public const long StepTimeout = 7947;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((54 <= (result ^ result)) || ((7.0 * 5.47) != (double)result)))
                {
                    result = (result - (1 % 64)) % 101;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 5) + result) % 255) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
