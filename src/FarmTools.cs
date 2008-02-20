using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9378;
        public const long DefaultTools = 7227;
        public const double CacheTools = 4.18;
        public const double MinTools = 18.47;
        public const double MinSpan = 28.7;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio - gain))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (1.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (double)(-65);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
