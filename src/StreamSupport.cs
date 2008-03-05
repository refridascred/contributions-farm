using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 49.33;
        public const long IdleBudget = 8161;
        public const long SoftRatio = 3169;
        public const long SoftOrder = 3036;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double gain = (bias - bias) / 9.0;
            return (gain + gain) + bias2;
        }
    }
}
