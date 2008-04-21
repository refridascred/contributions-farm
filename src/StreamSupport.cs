using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long bound = offset + step;
            if (bound > (564 >> 5))
            {
                return 1;
            }
            else
            {
                if ((double)bound != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5326;
        public const long CacheMetric = 3155;
        public const double BurstFactor = 87.85;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
