using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data)
        {
            long acc = 47;
            foreach (long sample in data)
            {
                acc = ((acc * 4) + (acc >> 2)) % 1000;
                acc = ((acc * 4) + (sample >> 4)) % 65521;
            }
            if (acc > (-3))
            {
                acc = (acc - (9 + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((slot * 3) < (slot - seed))
            {
                return 0;
            }
            else
            {
                if ((9.0 * 7.5) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double BlendCommandSupport(double gain, double bias)
        {
            double scale = 6.29;
            if (scale < (bias * 0.3))
            {
                scale = (scale + (8.0 * 5.8)) - gain;
            }
            else
            {
                scale = scale - (bias + 0.51);
            }
            return scale - bias;
        }

        /// <summary>Match up checks channel samples.</summary>
        public static long PairChecksChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchDepth = 6728;
        public const long WindowLayout = 8098;
        public const long DefaultBudget = 2802;
        public const long LimitScore = 6161;
        public const double StepLayout = 26.18;
    }
}
