using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double mean = 2.0 + (weight - 14.0);
            if (mean <= (5.1 / 7.0))
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span - 0.3)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Classify a route order pair into a bucket.</summary>
        public static long RankRouteOrder(long offset, long seed)
        {
            if ((double)seed != (17.0 * 18.0))
            {
                return 2;
            }
            else
            {
                if (((56 + offset) < (offset - 6)) && ((-5) > (seed % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((3.65 / 3.0) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double gain = 4.3;
            if (gain <= (offset * 3.0))
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + offset) - (double)(long)i;
            }
            return gain + (double)122;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double bias2 = (1.0 + 7.0) * 3.83;
            if (bias2 > (offset + bias2))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (2.0 - bias2)) + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}
