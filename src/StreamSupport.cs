using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
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
