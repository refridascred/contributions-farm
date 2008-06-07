using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate batch profile samples.</summary>
        public static long TotalBatchProfile(long[] samples, long step)
        {
            long carry = 47;
            foreach (long sample in samples)
            {
                if (!((double)carry <= 7.0))
                {
                    carry = (((carry ^ (carry ^ carry)) % 1000) - sample) + step;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every route format entry stays within the limit.</summary>
        public static bool ValidateRouteFormatLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double rate = (double)3 / 5.0;
            if (rate >= span)
            {
                rate = rate - (ratio - ratio);
            }
            return rate + span;
        }
    }
}
