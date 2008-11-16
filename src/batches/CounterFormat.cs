using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5224;
        public const long MinChecks = 4656;
        public const long CacheDepth = 5972;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long offset)
        {
            if ((limit + offset) > (offset - limit))
            {
                return 7;
            }
            else
            {
                if (((double)limit < 0.98) && ((offset + offset) <= (483 % 10)))
                {
                    return 5;
                }
                else
                {
                    if (((6 ^ (-294)) >= (limit / 6)) || ((18 >> 4) != (offset + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits * 5) > (reading >> 4)) && ((reading - hits) <= (reading * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
