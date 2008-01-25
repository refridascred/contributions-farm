using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 8242;
        public const double BurstBatches = 53.93;
        public const long HardFactor = 8279;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry - offset;
                if (offset <= (offset << 1))
                {
                    long tally = carry;
                    carry = (carry + tally) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long target)
        {
            long offset = floor + target;
            if ((offset - offset) >= offset)
            {
                return 5;
            }
            else
            {
                if ((199 ^ offset) < (offset % 2))
                {
                    return 3;
                }
                else
                {
                    if (floor > (0 * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 3) > (floor & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
