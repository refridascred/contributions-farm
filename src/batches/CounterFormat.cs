using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Queued,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Roll a payload order counter forward.</summary>
        public static long IteratePayloadOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 2) ^ (result & 1);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
