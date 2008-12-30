using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Failed,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 8999;
        public const long WindowLayout = 652;
        public const long WindowDepth = 4946;
    }
}
