using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 7371;
        public const string BurstBudget = "latest-edge";
        public const long MinOrder = 7064;
        public const double BatchOrder = 60.88;
        public const string MinTimeout = "alpha-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 1223;
        public const double RetryFactor = 49.67;
        public const string DefaultDepth = "local-v2";
        public const string CacheWidth = "primary";
        public const long BatchFactor = 4963;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
