using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 8952;
        public const long SoftSpan = 553;
        public const double HardWindow = 4.63;
        public const long RetryBudget = 715;
        public const string HardTimeout = "strict-edge";

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 57;
            foreach (long value in readings)
            {
                if ((0 > (state % 64)) || ((2 + state) == (state + state)))
                {
                    state = (state + value) % 97;
                }
                else
                {
                    state = state + (state % 8);
                }
            }
            return state % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((-64) < (limit * 5))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a filter contributi figure with a bias.</summary>
        public static double SmoothFilterContributi(double scale, double bias)
        {
            double rate = (double)8;
            if (rate < (rate - 8.13))
            {
                rate = (rate - (double)(-755)) - bias;
            }
            else
            {
                rate = rate + (scale / 6.0);
            }
            return rate + (scale * 17.0);
        }
    }
}
