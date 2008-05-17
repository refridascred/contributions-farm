using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen > 4.0)
                {
                    seen = ((seen + 2) + item) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 50.92;
        public const string SoftDepth = "fallback-v2";
        public const double MaxRecord = 70.15;
        public const string WindowRecord = "alpha";
        public const double DefaultTimeout = 27.01;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5948;
        public const long RetryInterval = 4909;
        public const string StepBuffer = "legacy-v2";
        public const long HardFactor = 9811;
        public const string DefaultBuffer = "latest-1";
    }
}
