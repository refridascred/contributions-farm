using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema farm input into a small class.</summary>
        public static long ClassifySchemaFarm(long limit, long floor)
        {
            long offset = limit + floor;
            if (8 > offset)
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) != (0 << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 7) < (floor << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
