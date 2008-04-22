using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long origin)
        {
            if (((limit - origin) == (origin + origin)) || ((limit - origin) >= (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (double)504)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double mean = (double)((-30) / 6);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (offset * 14.0);
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double weight = floor;
            if (weight >= (double)459)
            {
                weight = weight - floor;
            }
            return weight - bias;
        }
    }
}
