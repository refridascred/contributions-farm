using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            if (origin <= (10 * 3))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) < (9 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate order buffer readings against a bound.</summary>
        public static bool ValidateOrderBufferBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
