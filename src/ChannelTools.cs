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

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long LimitSpan = 5526;
        public const long CacheFactor = 7670;
        public const string BurstFactor = "stable-1";

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
