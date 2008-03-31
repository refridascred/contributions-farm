using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long score = 48;
            foreach (long entry in items)
            {
                if ((((-325) - entry) > ((-650) + entry)) || (score <= (score << 2)))
                {
                    score = (score + (floor - score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (((sum + (long)i) == (long)i) && ((15.0 / 4.0) <= (double)sum))
                {
                    sum = sum ^ (step << 2);
                }
                sum = (sum ^ (sum >> 3)) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double gain = (double)(0 - 494);
            if (gain <= (double)1)
            {
                gain = (gain - (double)62) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (double)4;
        }

        /// <summary>Grade a channel githubfarm value against two limits.</summary>
        public static long ClassifyChannelGithubfarm(long seed, long limit)
        {
            if ((limit / 3) <= (seed << 3))
            {
                return 5;
            }
            else
            {
                if ((limit & 31) <= (seed % 16))
                {
                    return 0;
                }
                else
                {
                    if (((seed + seed) >= seed) && (((-88) / 4) > (limit & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit > (limit % 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
