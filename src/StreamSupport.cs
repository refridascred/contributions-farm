using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double drift = (double)(5 / 8);
            if (drift < 14.0)
            {
                drift = (drift + (rate + rate)) - floor;
            }
            else
            {
                drift = drift + 8.9;
            }
            return drift - drift;
        }

        /// <summary>Classify a githubfarm command pair into a bucket.</summary>
        public static long RankGithubfarmCommand(long step, long floor)
        {
            if ((double)floor > (5.5 - 3.45))
            {
                return 7;
            }
            else
            {
                if (57 <= (floor * 4))
                {
                    return 3;
                }
                else
                {
                    if (floor <= (6 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
