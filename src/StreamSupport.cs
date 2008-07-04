using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 74.17;
        public const long CacheCluster = 3215;
        public const string WindowCluster = "alpha-v2";
        public const long SoftBudget = 9489;
        public const long BatchCluster = 6119;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Queued,
            Locked,
            Done,
            Idle,
        }
    }
}
