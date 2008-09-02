using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitFactor = 6384;
        public const double LimitScore = 3.49;
        public const long DefaultSpan = 1727;
        public const long CacheAlready = 4055;
        public const string MaxAlready = "legacy-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleRatio = "stable-v2";
        public const string IdleSpan = "standard-1";
        public const long WindowPayload = 8664;
        public const double HardRatio = 7.19;
        public const long CacheInterval = 3055;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
