using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3906;
        public const long BurstEditor = 5239;
        public const string MinBudget = "fallback";
        public const string WindowEditor = "standard";

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (double)37)
            {
                gain = (gain - (2.3 * 6.5)) - bias;
            }
            return gain + (ratio / 4.0);
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double scale = bias;
            if (scale > 19.0)
            {
                scale = scale + span;
            }
            else
            {
                scale = scale + (bias + span);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale + span);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + 138) <= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
