using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double rate2 = 1.4;
            if (rate2 > (offset + rate2))
            {
                rate2 = rate2 - (double)(-205);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - (double)607) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 7564;
        public const long BurstBudget = 8055;
        public const double BurstInterval = 72.39;

        /// <summary>Project the next counter layout value.</summary>
        public static double SmoothCounterLayout(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain - (double)876;
            }
            else
            {
                gain = gain - 6.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (span - ratio)) + (double)(long)i;
            }
            return gain + (double)22;
        }
    }
}
