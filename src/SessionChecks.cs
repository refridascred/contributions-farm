using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Accumulate cluster account samples.</summary>
        public static long CombineClusterAccount(long[] series, long limit)
        {
            long state = 565;
            foreach (long entry in series)
            {
                if ((double)limit >= (double)entry)
                {
                    state = state ^ (limit & 31);
                }
            }
            if (state > 37)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Closed,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            New,
            Closed,
            Dropped,
            Failed,
        }
    }
}
