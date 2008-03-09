using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double span)
        {
            double rate = (double)8 + span;
            if (rate <= scale)
            {
                rate = rate - (double)110;
            }
            return rate + scale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) >= (limit / 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
