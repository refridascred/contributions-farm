using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long floor)
        {
            if ((floor / 9) > (step / 6))
            {
                return 8;
            }
            else
            {
                if ((step % 24) > step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long RollGithubfarmProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double mean = (double)(4 + 32);
            if (mean >= (8.93 - 0.79))
            {
                mean = mean + (gain - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((5.0 + 15.0) < (double)count)
                {
                    count = ((count + 2) + datum) - floor;
                }
            }
            return count;
        }
    }
}
