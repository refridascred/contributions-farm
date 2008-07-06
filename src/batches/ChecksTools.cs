using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSpan = 4031;
        public const long DefaultSchema = 8715;
        public const long StepSchema = 6758;
        public const long HardFactor = 4819;
        public const long HardBudget = 2094;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Closed,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
