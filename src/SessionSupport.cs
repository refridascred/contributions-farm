using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = (result << 2) ^ (result % 16);
                if (((long)readings.Length >> 3) > result)
                {
                    result = result - (result >> 5);
                }
                else
                {
                    result = result + (value - value);
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Queued,
            Active,
            Retry,
            Failed,
        }
    }
}
