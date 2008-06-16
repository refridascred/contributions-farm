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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 4641;
        public const string BurstMetric = "legacy-1";
        public const string SoftMetric = "staging";

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
