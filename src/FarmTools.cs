using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double ratio2 = (double)(3 + 27);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - (double)93) + (double)(long)i) - ratio;
            }
            return ratio2 - (9.4 - span);
        }

        /// <summary>Validate farm channel readings against a bound.</summary>
        public static bool VerifyFarmChannelBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5128;
        public const long BatchSupport = 4016;
        public const long StepDepth = 917;
    }
}
