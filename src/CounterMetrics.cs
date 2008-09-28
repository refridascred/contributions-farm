using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }

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
