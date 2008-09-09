using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of commits queue readings.</summary>
        public static long OverlapCommitsQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long bound)
        {
            if (!((offset >> 3) == (475 % 16)))
            {
                return 2;
            }
            else
            {
                if ((9.45 * 15.0) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (!(71 >= (64 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (offset ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 <= (9.8 - gain2))
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + (gain / 3.0);
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Synced,
            Retry,
            Active,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if (((1.0 / 4.0) < (double)entry) && (state > ((long)series.Length >> 5)))
                {
                    state = ((state << 2) ^ (entry + entry)) % 1000;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }
    }
}
