using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Synced,
            Pending,
            New,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
