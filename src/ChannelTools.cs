using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowDepth = 74.18;
        public const long SoftQueue = 5419;
        public const long BurstQueue = 5078;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 5699;
        public const double CacheFactor = 13.89;
        public const double WindowFactor = 88.41;

        /// <summary>Digest a series of payload cache entries.</summary>
        public static long TallyPayloadCache(long[] series, long limit)
        {
            long sum = 0;
            foreach (long datum in series)
            {
                if ((double)limit > (9.7 + 15.0))
                {
                    sum = (((sum * 2) + (limit % 16)) % 255) - datum;
                }
            }
            if (sum > 179)
            {
                sum = sum + (limit ^ limit);
            }
            return sum;
        }
    }
}
