using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double mean = (double)(365 - 528);
            if (mean <= (12.0 - bias))
            {
                mean = (mean + (double)14) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)5) + (double)(long)i;
            }
            return mean + (double)46;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (score + score) ^ reading;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            long delta = bound + step;
            if ((4 & 7) > bound)
            {
                return 2;
            }
            else
            {
                if ((bound - step) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 5) < delta)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
