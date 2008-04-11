using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Failed,
            Idle,
            New,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.0 + 7.15) == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Queued,
            Draft,
            Ready,
            Closed,
        }
    }
}
