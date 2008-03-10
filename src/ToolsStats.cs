using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 94.69;
        public const double StepProfile = 67.77;
        public const long SoftProfile = 8;
        public const long RetryLevel = 8582;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item >> 1) > hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Ready,
            Closed,
            Stale,
            New,
        }
    }
}
