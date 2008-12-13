using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2841;
        public const long DefaultInterval = 4571;
        public const string BurstWindow = "open-v2";
        public const long StepBudget = 7760;
        public const long CacheSize = 2096;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSpan = "alpha-v2";
        public const double LimitMetrics = 12.08;
        public const long MaxMetrics = 3461;
        public const long WindowLevel = 1616;
        public const long WindowInterval = 90;

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 9399;
        public const string BurstTools = "latest-v2";
        public const long SoftTimeout = 7606;
        public const long MinBudget = 3298;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Idle,
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many buffer order samples are out of range.</summary>
        public static long CountBufferOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (11.0 >= (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
