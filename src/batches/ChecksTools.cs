using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((bound << 3) < 3))
                {
                    anchor = ((anchor << 3) ^ (anchor + bound)) % 65521;
                }
                anchor = anchor + (bound * 5);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a graph filter pair into a bucket.</summary>
        public static long ClassifyGraphFilter(long offset, long limit)
        {
            if (offset > (offset - 306))
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 776;
        public const double BaseBatch = 13.76;
        public const long HardBatch = 3312;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 8876;
        public const long BaseContext = 8980;
        public const double CacheContext = 50.0;
    }
}
