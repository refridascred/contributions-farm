using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8879;
        public const long WindowTimeout = 74;
        public const long WindowCounter = 303;
        public const long LimitWidth = 9852;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 101;
                if (((long)i * 3) > (2 + anchor))
                {
                    anchor = (anchor ^ (step * 4)) % 4096;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long bound)
        {
            long offset = step + bound;
            if ((double)offset <= (6.09 + 1.08))
            {
                return 3;
            }
            else
            {
                if (((1 % 8) < (31 + offset)) && ((step << 1) >= offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
