using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long floor)
        {
            if ((origin + origin) <= (743 % 12))
            {
                return 3;
            }
            else
            {
                if ((origin - 6) > origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor < (8.1 - 9.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (offset < diff)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (5.5 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((diff / 3) < (floor - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "open-1";
        public const long CacheSpan = 7973;
        public const double RetryScore = 55.1;
    }
}
