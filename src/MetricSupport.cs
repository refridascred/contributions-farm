using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 321;
            foreach (long entry in items)
            {
                mix = ((mix << 2) ^ (3 / 7)) + entry;
            }
            return mix;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}
