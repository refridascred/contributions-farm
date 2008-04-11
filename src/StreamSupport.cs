using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (floor <= lane)
            {
                return 0;
            }
            else
            {
                if ((9.0 + 4.0) >= (double)lane)
                {
                    return 4;
                }
                else
                {
                    if (!(((-98) - lane) > (offset + lane)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane >= (8.95 + 1.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm layout value.</summary>
        public static double ScaleGithubfarmLayout(double weight, double bias)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = mean - weight;
            }
            return mean + weight;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
