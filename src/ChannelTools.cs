using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 7445;
        public const double SoftScore = 24.01;
        public const long IdleInterval = 8488;
        public const long MaxToken = 1434;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Synced,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
