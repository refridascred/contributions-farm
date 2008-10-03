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

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = 1.42 - (offset * 1.7);
            if (ratio > gain)
            {
                ratio = ratio - (ratio / 9.0);
            }
            return ratio - ratio;
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
