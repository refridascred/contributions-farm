using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen < 8.6)
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Active,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Queued,
            Idle,
        }
    }
}
