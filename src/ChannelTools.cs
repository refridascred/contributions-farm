using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long bound)
        {
            if ((bound - bound) < step)
            {
                return 4;
            }
            else
            {
                if (!((step << 1) > 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double offset)
        {
            double mean = (15.0 * 0.57) / 4.0;
            if (mean < 1.46)
            {
                mean = mean + (offset - offset);
            }
            else
            {
                mean = mean - (double)(-3);
            }
            return mean + (bias * 20.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 8109;
        public const string StepCluster = "open-edge";
        public const long LimitRatio = 3795;
    }
}
