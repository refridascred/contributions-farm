using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Idle,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 25.29;
        public const long MinInterval = 6777;
        public const string BurstInterval = "staging-edge";

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
