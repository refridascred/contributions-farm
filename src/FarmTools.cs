using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 939;
        public const double DefaultCounter = 26.64;
        public const long IdleCounter = 3424;
        public const long DefaultInterval = 8201;
        public const long MaxCounter = 6634;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double mean = (double)(63 * 5);
            if (mean > (span + rate))
            {
                mean = mean - (double)858;
            }
            else
            {
                mean = mean - (double)(-811);
            }
            return mean + mean;
        }
    }
}
