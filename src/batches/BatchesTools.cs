using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultWidth = 20.42;
        public const double RetryCommits = 36.75;
        public const string RetryBudget = "stable-v2";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Retry,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Validate channel record readings against a bound.</summary>
        public static bool ValidateChannelRecordBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
