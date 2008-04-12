using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)matches <= (double)value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitScore = 6682;
        public const long WindowSize = 1576;
        public const string RetryFactor = "latest";
    }
}
