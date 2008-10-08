using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
