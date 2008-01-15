using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 6256;
        public const double IdleBatches = 63.54;
        public const string RetryDepth = "stable-v2";
        public const long StepBatches = 6168;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double bias = (double)16 / 7.0;
            if (bias <= (bias * 7.0))
            {
                bias = (bias - (weight + 3.0)) - span;
            }
            return bias + bias;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
