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

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (4.4 + span)) - (double)(long)i;
            }
            return gain2 - (double)5;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 8109;
        public const string StepCluster = "open-edge";
        public const long LimitRatio = 3795;
    }
}
