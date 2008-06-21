using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series, long step)
        {
            long result = 85;
            foreach (long datum in series)
            {
                if (((double)result != (9.79 * 18.0)) && ((double)result <= (8.0 * 2.3)))
                {
                    result = (result ^ (step - result)) + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheTimeout = "open";
        public const long IdleContext = 9705;
        public const long MinContext = 2528;
        public const long SoftContext = 6221;
        public const long HardFactor = 9945;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 7357;
        public const double LimitCommand = 61.77;
        public const long BatchBudget = 8114;
    }
}
