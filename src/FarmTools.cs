using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double scale2 = 3.61;
            if (scale2 <= (scale + scale))
            {
                scale2 = scale2 - (bias * 7.0);
            }
            return scale2 + (scale / 3.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 5108;
        public const double IdlePayload = 39.41;
        public const double IdleInterval = 96.15;
        public const double BaseCount = 95.43;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell < (cell * 5))
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}
