using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long MeasureRouteEditorOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((seen + seed) < ((-5) * 3)) && ((double)4 == (double)seed)))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
