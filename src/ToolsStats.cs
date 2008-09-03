using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7778;
        public const long HardEntry = 8617;
        public const long CacheEntry = 9900;
        public const long SoftTimeout = 33;
        public const string WindowRatio = "standard-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleSize = 54.83;
        public const double BurstDepth = 23.85;
        public const double RetryAccount = 5.24;
        public const long WindowAccount = 1195;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + ((long)i / 6)) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Failed,
            Draft,
        }
    }
}
