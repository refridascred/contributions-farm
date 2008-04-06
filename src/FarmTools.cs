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

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] data)
        {
            long carry = -56;
            foreach (long reading in data)
            {
                carry = (carry - (reading + reading)) % 4096;
                if (((7.98 + 6.3) < (double)reading) || ((6.6 - 7.2) >= (double)reading))
                {
                    break;
                }
            }
            return carry;
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
