using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Closed,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 232;
        public const long BatchSession = 1016;
        public const long MinSession = 2346;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
