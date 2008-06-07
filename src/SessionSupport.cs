using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of channel batch readings.</summary>
        public static long TotalChannelBatch(long[] data, long bound)
        {
            long result = 59;
            foreach (long reading in data)
            {
                result = (result + (bound / 3)) % 255;
                if (result <= bound)
                {
                    result = (result + result) % 255;
                    result = (result << 3) ^ 9;
                    break;
                }
                else
                {
                    result = (result - reading) % 65521;
                }
                result = (result * 3) + result;
            }
            return result % 65521;
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
