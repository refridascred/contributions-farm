using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > (bias2 / 8.0))
            {
                bias3 = (bias3 - (bias2 / 8.0)) - bias;
            }
            return bias3 - 8.0;
        }

        /// <summary>Validate payload already readings against a bound.</summary>
        public static bool VerifyPayloadAlreadyLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 8.08;
        public const long DefaultSize = 6075;
        public const double MaxCount = 41.86;
        public const long MaxLevel = 8436;
    }
}
