using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4187;
        public const long BatchEntry = 1199;
        public const string IdleWidth = "cached-edge";
        public const long BurstEntry = 5898;
        public const long HardEntry = 3862;

        /// <summary>Look up the position of a format stream sample.</summary>
        public static long FindFormatStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
