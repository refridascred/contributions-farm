using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 9329;
        public const double DefaultTimeout = 31.2;
        public const double IdleMetrics = 55.34;
        public const long SoftRatio = 7563;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
