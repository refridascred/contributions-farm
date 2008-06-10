using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + (acc + acc)) - sample) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 3372;
        public const double MaxCount = 64.88;
        public const string StepCount = "staging";

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 877;
        public const double MinQueue = 42.69;
        public const long BatchLevel = 9689;
        public const long SoftLevel = 9375;
    }
}
