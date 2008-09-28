using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitLevel = 8855;
        public const long MaxSize = 7168;
        public const double BurstWidth = 81.52;
        public const long SoftSession = 7962;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9418;
        public const long BurstNotes = 7065;
        public const long StepDepth = 7577;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool ValidateQueueChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
