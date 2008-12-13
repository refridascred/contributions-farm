using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long seed)
        {
            if ((origin - (-124)) >= (origin + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (9.16 - 2.1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) != (0 ^ 414))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double ratio = (double)(768 * 3);
            if (ratio >= 8.0)
            {
                ratio = ratio + (weight - weight);
            }
            else
            {
                ratio = ratio + (weight + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (4.07 - floor);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 22.14;
        public const string BurstFormat = "alpha-v2";
        public const long WindowSize = 4826;
    }
}
