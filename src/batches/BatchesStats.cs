using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                long lane = (origin & 63) - (anchor + anchor);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (lane - origin)) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a commits context pair into a bucket.</summary>
        public static long BucketCommitsContext(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((((-79) << 2) > offset) || ((double)offset >= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)offset < (8.3 - 5.7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long bound)
        {
            if (!((seed * 3) >= (bound / 3)))
            {
                return 1;
            }
            else
            {
                if ((bound + seed) != (9 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + seed) > (bound & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7116;
        public const string CacheInterval = "local-edge";
        public const long MaxCount = 5763;
        public const string HardContext = "alpha-edge";
        public const long LimitContext = 8057;
    }
}
