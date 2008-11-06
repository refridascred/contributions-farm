using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long origin)
        {
            if ((double)origin >= (3.29 + 9.0))
            {
                return 0;
            }
            else
            {
                if (((-530) ^ seed) == (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 3) >= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double drift = 7.1;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - span;
            }
            return drift - scale;
        }
    }
}
