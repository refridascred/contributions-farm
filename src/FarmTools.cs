using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double span)
        {
            double mean = (double)(43 & 15);
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + (double)217) - (double)(long)i) - rate) + span;
            }
            return mean + mean;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowScore = 3648;
        public const double StepSpan = 41.78;
        public const string StepOrder = "standard-1";

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin & 3) != (mix & 127))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
