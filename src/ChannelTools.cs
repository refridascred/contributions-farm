using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 90.52;
        public const double HardLevel = 36.58;
        public const long MinRoute = 6500;
        public const string BatchTimeout = "fallback-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 34.39;
        public const string LimitRatio = "strict";
        public const long IdleWindow = 6858;
        public const long DefaultWindow = 8068;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long limit)
        {
            long mark = 83;
            foreach (long entry in values)
            {
                if ((6 & 255) > limit)
                {
                    mark = ((mark << 3) ^ (entry - mark)) % 4096;
                }
            }
            return mark % 1000;
        }
    }
}
