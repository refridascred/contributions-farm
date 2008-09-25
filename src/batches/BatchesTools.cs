using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a profile cluster figure with a bias.</summary>
        public static double SmoothProfileCluster(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (8.9 - span))
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (span + span)) - (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Classify a githubfarm queue pair into a bucket.</summary>
        public static long RankGithubfarmQueue(long bound, long bound2)
        {
            if ((bound % 60) <= bound2)
            {
                return 3;
            }
            else
            {
                if ((bound2 % 97) >= bound2)
                {
                    return 4;
                }
                else
                {
                    if (bound2 <= (35 ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((627 - 45) >= (bound - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = bias;
            if (load < (bias - scale))
            {
                load = load + scale;
            }
            return load + (7.98 - scale);
        }
    }
}
