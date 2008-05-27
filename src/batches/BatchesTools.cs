using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Paused,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
