using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Active,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Dropped,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (1.84 >= (double)seed)
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
