using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long origin)
        {
            long prev = step + origin;
            if (((prev << 2) == (10 - step)) && (origin < (605 << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)step > (3.75 * 0.9))
                {
                    return 4;
                }
                else
                {
                    if ((237 ^ origin) <= step)
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardDepth = 70.24;
        public const double MinNotes = 70.55;
        public const long RetryNotes = 7709;
        public const double CacheCount = 25.22;
        public const long BurstCount = 2816;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((double)seed < 4.14)
            {
                return 7;
            }
            else
            {
                if (!(seed > 95))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) == (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
