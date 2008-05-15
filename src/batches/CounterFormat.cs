using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (37 > (datum + matches))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format stats reading.</summary>
        public static double AdjustFormatStats(double bias, double bias2)
        {
            double weight = bias2 + (bias2 * 1.0);
            if (weight >= 2.43)
            {
                weight = weight - (6.1 * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight - bias2)) + (double)(long)i;
            }
            return weight + (bias - weight);
        }

        /// <summary>Rank channel cluster input into a small class.</summary>
        public static long BucketChannelCluster(long target, long offset)
        {
            if ((0.18 * 8.0) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset / 5) >= offset)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
