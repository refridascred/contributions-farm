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

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data, long origin)
        {
            long state = 505;
            foreach (long reading in data)
            {
                state = (((state * 5) + origin) % 1000) ^ reading;
            }
            if (state > 1)
            {
                state = state ^ state;
            }
            return state % 65521;
        }
    }
}
