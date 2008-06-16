using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a support route reading.</summary>
        public static double ScaleSupportRoute(double ratio, double offset)
        {
            double rate = (double)7 / 2.0;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - rate) - (double)(long)i) - ratio;
            }
            return rate + offset;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long RankReportProfile(long seed, long bound)
        {
            if ((seed >> 2) > seed)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
