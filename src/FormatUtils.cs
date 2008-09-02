using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 3132;
        public const long MinFarm = 7453;
        public const long BaseRatio = 325;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - (mix + origin);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Queued,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstInterval = 92.91;
        public const string LimitScore = "fallback-edge";
        public const long CacheSize = 507;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseDepth = 3532;
        public const double LimitFormat = 26.7;
        public const long MaxLevel = 3349;
        public const double HardFormat = 24.29;
        public const long WindowFormat = 4605;
    }
}
