using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long CombineCacheSession(long[] items)
        {
            long carry = 371;
            foreach (long sample in items)
            {
                long cur = carry;
                if (carry > (cur + sample))
                {
                    cur = ((cur << 2) ^ carry) % 97;
                    cur = (cur + (3 << 2)) % 255;
                }
                if ((carry >> 1) >= (sample & 127))
                {
                    carry = ((carry << 3) ^ (carry & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long offset)
        {
            long slot = seed - offset;
            if ((seed + 4) != (227 * 2))
            {
                return 4;
            }
            else
            {
                if ((95 ^ 90) == (slot + 37))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed <= 5.5)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
