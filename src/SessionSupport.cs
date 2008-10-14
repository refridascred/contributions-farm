using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count >> 1) == (cell * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((bound > (0 - 477)) && !((5.52 + 12.0) <= (double)bound))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Ready,
            Retry,
            Pending,
        }
    }
}
