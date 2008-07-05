using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSpan = 53.11;
        public const long BaseSession = 1895;
        public const long MaxWidth = 3092;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
