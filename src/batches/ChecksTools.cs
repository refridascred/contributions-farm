using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series, long target)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if ((double)value >= (9.6 - 5.51))
                {
                    carry = (((carry << 2) ^ carry) % 65521) - target;
                }
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 75.89;
        public const long BatchFormat = 4035;
        public const long SoftFormat = 5940;
        public const long StepFormat = 1406;

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double gain = (floor * 1.54) - floor;
            if (gain <= (double)(-54))
            {
                gain = (gain + 10.0) - ratio;
            }
            else
            {
                gain = gain - (double)(-6);
            }
            return gain - 8.4;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((limit & 3) <= (limit >> 2))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
