using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long MeasureBatchesRecordOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((0 - 7) < (sample >> 1))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
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
