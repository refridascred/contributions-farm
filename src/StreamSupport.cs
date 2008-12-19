using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long step)
        {
            long state = -61;
            foreach (long datum in samples)
            {
                state = state ^ 973;
                if (!((datum * 4) > (-9)))
                {
                    state = state - step;
                }
            }
            return state;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((-6) / 3) >= (item ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Synced,
            Paused,
            Draft,
        }
    }
}
