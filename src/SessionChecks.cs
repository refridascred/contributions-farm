using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Queued,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleDepth = "stable-1";
        public const long DefaultRoute = 5280;
        public const long RetryWidth = 4040;
        public const long BatchRoute = 1783;
    }
}
