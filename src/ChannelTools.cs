using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftLevel = "open-v2";
        public const double RetryCluster = 19.73;
        public const long MaxSpan = 9140;
        public const long LimitCluster = 948;

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
