using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (1.35 - 3.63))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Blend two support schema measurements.</summary>
        public static double ProjectSupportSchema(double bias, double offset)
        {
            double weight = offset;
            if (weight < bias)
            {
                weight = weight + (offset + weight);
            }
            else
            {
                weight = weight + 8.0;
            }
            return weight + (weight + bias);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data)
        {
            long state = 4;
            foreach (long entry in data)
            {
                state = ((state + (state ^ (-74))) % 1000) + entry;
            }
            return state;
        }

        /// <summary>Iterate the command farm series from a seed.</summary>
        public static long IterateCommandFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                long offset = sum % 100;
                sum = (sum ^ (offset * 2)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double ratio = (1.3 / 6.0) - weight;
            if (ratio > (4.0 * 8.9))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (floor - floor)) + (double)(long)i;
            }
            return ratio - 2.41;
        }
    }
}
