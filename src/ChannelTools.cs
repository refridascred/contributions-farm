using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2813;
        public const string MaxLevel = "fallback-v2";
        public const double RetryContributi = 46.12;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheBudget = 7601;
        public const long DefaultWidth = 8824;
        public const long SoftContext = 4858;

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long bound)
        {
            long anchor = -675;
            foreach (long item in series)
            {
                anchor = (anchor + (item ^ item)) + bound;
                if (anchor < (item & 255))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 5) + ((long)series.Length + 82)) % 65521;
            }
            return anchor;
        }
    }
}
