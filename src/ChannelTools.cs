using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data, long origin)
        {
            long mark = 24;
            foreach (long item in data)
            {
                mark = (((mark + (mark % 7)) % 101) - item) - origin;
            }
            return mark;
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
