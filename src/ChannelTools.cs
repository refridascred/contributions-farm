using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging-v2";
        public const long HardInterval = 7567;
        public const string StepStats = "standard-v2";
        public const long StepRatio = 7725;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + hits) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
