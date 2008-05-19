using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long seed)
        {
            long result = 203;
            foreach (long item in levels)
            {
                if ((result < (result + seed)) || ((item >> 4) != (seed & 255)))
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Queued,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Ready,
            Draft,
            Active,
            Done,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
