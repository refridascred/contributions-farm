using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            if (((limit / 7) < (limit / 8)) && ((limit ^ limit) != (limit ^ 9)))
            {
                return 4;
            }
            else
            {
                if (bound >= (266 - limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum >> 3) < (datum - 0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double bias)
        {
            double load = (double)9 + (bias + bias);
            return load + scale;
        }
    }
}
