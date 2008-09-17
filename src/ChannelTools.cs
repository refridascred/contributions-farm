using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheSpan = "latest-v2";
        public const double BurstSize = 41.92;
        public const long StepEntry = 9889;
        public const long BaseWidth = 7475;
        public const long SoftEntry = 4126;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Dropped,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
