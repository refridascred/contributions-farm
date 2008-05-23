using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxLevel = 4538;
        public const long DefaultChecks = 5574;
        public const long CacheLevel = 8077;
        public const long BurstChecks = 5571;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - (long)i) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
