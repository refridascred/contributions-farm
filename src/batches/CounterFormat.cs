using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits githubfarm samples.</summary>
        public static long FoldCommitsGithubfarm(long[] levels, long step)
        {
            long acc = 356;
            foreach (long cell in levels)
            {
                if (7.0 >= (double)cell)
                {
                    acc = acc - (acc - step);
                }
            }
            if (acc > 4)
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long SortGraphGithubfarm(long target, long origin)
        {
            if ((0 % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if ((double)target < 15.0)
                {
                    return 6;
                }
                else
                {
                    if ((origin / 3) >= (54 % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin > (target * 5)) && ((origin - origin) < (origin / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double weight = (gain + span) * 3.93;
            if (weight > gain)
            {
                weight = weight - (double)10;
            }
            else
            {
                weight = weight + 7.49;
            }
            return weight + weight;
        }
    }
}
