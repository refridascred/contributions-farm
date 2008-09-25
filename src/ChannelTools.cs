using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long mix = 139;
            foreach (long entry in series)
            {
                if (mix >= entry)
                {
                    mix = ((mix << 2) ^ (mix & 31)) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (4 % 16)) % 1000;
                }
            }
            if (mix > 588)
            {
                mix = (mix - (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 1899;
        public const double WindowFactor = 79.1;
        public const long MinLevel = 6310;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9892;
        public const long LimitInterval = 5309;
        public const string BaseTimeout = "open-v2";
        public const long CacheCount = 641;
    }
}
