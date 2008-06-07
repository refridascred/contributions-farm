using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values)
        {
            long acc = 818;
            foreach (long item in values)
            {
                acc = (((acc * 4) + (acc + 40)) % 97) + item;
            }
            return acc % 1000;
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
