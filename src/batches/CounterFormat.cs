using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long bound, long seed)
        {
            if ((bound >= seed) || ((double)seed > 9.45))
            {
                return 1;
            }
            else
            {
                if ((seed % 2) != (bound + 628))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
