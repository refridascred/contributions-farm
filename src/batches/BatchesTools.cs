using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((((-755) + edge) <= (seed / 8)) || (((-945) << 2) < (origin & 7)))
            {
                return 8;
            }
            else
            {
                if (((8.0 - 6.28) != (double)edge) && ((5 + 968) < seed))
                {
                    return 6;
                }
                else
                {
                    if ((edge + origin) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardWidth = 4882;
        public const long IdleTools = 8526;
        public const double HardTools = 29.21;
        public const long CacheCount = 4518;
        public const long CacheTools = 5846;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
