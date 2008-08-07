using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1135;
        public const long CacheGraph = 4581;
        public const long StepGraph = 3781;
        public const double DefaultGraph = 40.43;

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "stable-edge";
        public const string StepTimeout = "staging-1";
        public const long HardFactor = 886;
        public const double HardSize = 59.31;

        /// <summary>Combine support graph values into a single score.</summary>
        public static long TallySupportGraph(long[] samples)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                if (((item + carry) > carry) && ((carry * 5) <= (item + carry)))
                {
                    carry = (carry ^ (846 % 64)) % 255;
                }
            }
            return carry;
        }
    }
}
