using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Done,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (813 <= (sample - 238))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Ready,
            Idle,
            Synced,
            Retry,
        }
    }
}
