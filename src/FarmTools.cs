using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9768;
        public const double StepDepth = 97.38;
        public const long WindowFactor = 2477;
        public const long BaseTimeout = 1663;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double floor)
        {
            double ratio = (7.3 - floor) + (rate / 8.0);
            if (ratio < (double)(-5))
            {
                ratio = ratio + (ratio + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)844) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
