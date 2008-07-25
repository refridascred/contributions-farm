using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "primary";
        public const long CacheLevel = 2848;
        public const long BatchAccount = 822;

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "standard";
        public const long StepChecks = 7620;
        public const long DefaultBudget = 1573;
        public const double MinInterval = 79.13;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
