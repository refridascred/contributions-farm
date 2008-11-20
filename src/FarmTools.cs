using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 5392;
        public const long SoftChannel = 8001;
        public const string IdleScore = "primary-edge";
        public const long MaxChannel = 8625;
        public const long BatchChannel = 6456;

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchDepth = "local";
        public const long CacheRecord = 2104;
        public const long SoftInterval = 2225;
        public const long BatchCount = 141;
        public const double DefaultRecord = 13.04;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
