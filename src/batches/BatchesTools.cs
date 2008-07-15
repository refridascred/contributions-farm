using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2499;
        public const string IdleRatio = "fallback-1";
        public const long IdleContext = 9852;
        public const long RetryTimeout = 5172;
        public const long BurstContext = 8843;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((683 / 9) == ((long)readings.Length * 3))
                {
                    hits = ((hits + 2) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 2619;
        public const double StepTimeout = 98.31;
        public const long RetryStream = 5443;
    }
}
