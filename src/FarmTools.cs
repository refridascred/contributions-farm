using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double gain = bias / 2.0;
            if (gain < (double)80)
            {
                gain = (gain + gain) - floor;
            }
            return gain + gain;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2442;
        public const long MinOrder = 7310;
        public const long SoftOrder = 9969;

        /// <summary>Scale a checks account figure with a bias.</summary>
        public static double ProjectChecksAccount(double rate, double offset)
        {
            double mean = (double)(1 + 520);
            if (mean > (rate - rate))
            {
                mean = mean + 20.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 9.8) + (double)(long)i;
            }
            return mean - (offset * 8.0);
        }
    }
}
