using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long ClassifyCommitsCluster(long target, long offset)
        {
            long delta = target - offset;
            if (target > (offset + delta))
            {
                return 3;
            }
            else
            {
                if ((target * 2) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (((target / 9) >= (3 + target)) || (((-3) + delta) > ((-9) - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = scale / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4701;
        public const long StepLevel = 854;
        public const long IdleSession = 7675;
        public const long StepSession = 5942;
        public const long SoftBudget = 8878;
    }
}
