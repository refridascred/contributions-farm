using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchWidth = 2659;
        public const string SoftInterval = "fallback";
        public const string LimitCount = "latest-v2";
        public const long BurstScore = 5934;
        public const long HardChannel = 6100;

        /// <summary>Locate a stats layout reading by value.</summary>
        public static long LookupStatsLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            if (origin > (offset / 3))
            {
                return 8;
            }
            else
            {
                if ((offset ^ origin) == (offset & 7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
