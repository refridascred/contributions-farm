using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a layout channel figure with a bias.</summary>
        public static double ProjectLayoutChannel(double scale, double offset)
        {
            double mean = 11.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + offset) + (double)(long)i) + scale;
            }
            return mean + (offset * 2.16);
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
