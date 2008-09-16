using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next schema context value.</summary>
        public static double ProjectSchemaContext(double ratio, double span)
        {
            double ratio2 = (double)51;
            if (ratio2 > (8.3 - span))
            {
                ratio2 = (ratio2 - (span / 8.0)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - span) + (double)(long)i;
            }
            return ratio2 - (double)695;
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
