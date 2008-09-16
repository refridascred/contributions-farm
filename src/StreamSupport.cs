using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long seed)
        {
            long carry = 92;
            foreach (long value in items)
            {
                carry = (((carry << 2) ^ carry) ^ value) + seed;
            }
            if (carry > 745)
            {
                carry = (carry - carry) % 101;
            }
            return carry % 97;
        }

        /// <summary>Combine account queue values into a single score.</summary>
        public static long TotalAccountQueue(long[] readings)
        {
            long anchor = -2;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (anchor >> 3))
                {
                    anchor = (anchor - anchor) ^ datum;
                }
            }
            if (anchor < 99)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long SortWindowPayload(long floor, long target)
        {
            if ((floor - target) <= target)
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (10.0 * 6.0))
                {
                    return 4;
                }
                else
                {
                    if (((3.0 / 3.0) != (double)floor) || ((double)target == (double)(-32)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
