using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if ((318 - offset) >= (limit >> 2))
            {
                return 0;
            }
            else
            {
                if ((13.0 - 2.0) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 7.0) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const double MaxRoute = 97.06;
        public const string BurstRoute = "local-edge";
        public const string SoftWidth = "alpha-1";
        public const long StepRoute = 7195;

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double scale = bias;
            if (scale > (double)75)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 3.0) + (double)(long)i;
            }
            return scale + (ratio * 7.2);
        }
    }
}
