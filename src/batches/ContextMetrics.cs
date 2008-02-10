using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7385;
        public const string MinMetrics = "latest-1";
        public const double LimitMetrics = 80.48;
        public const double BatchBudget = 16.54;

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Idle,
            Ready,
            Failed,
        }
    }
}
