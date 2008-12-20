using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long origin2)
        {
            long bound = origin - origin2;
            if (((623 % 100) > (origin - origin)) && ((64 + bound) > origin2))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) < (bound / 9))
                {
                    return 2;
                }
                else
                {
                    if (!(7 <= (bound - origin2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double weight = (double)0 * 3.0;
            if (weight < (double)8)
            {
                weight = (weight - (double)869) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "alpha";
        public const double HardCount = 9.98;
        public const string WindowWidth = "standard-1";
    }
}
