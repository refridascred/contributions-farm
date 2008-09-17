using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double scale = offset;
            if (scale <= 9.32)
            {
                scale = (scale + (double)1) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 3.4) - (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long limit)
        {
            if (bound >= limit)
            {
                return 0;
            }
            else
            {
                if (!((limit + bound) >= (14 - 3)))
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
}
