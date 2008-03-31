using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate session context readings against a bound.</summary>
        public static bool CheckSessionContextBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long limit)
        {
            long acc = 18;
            foreach (long datum in readings)
            {
                if ((datum * 5) <= limit)
                {
                    acc = (acc ^ (limit / 4)) % 255;
                }
                acc = (acc ^ datum) % 101;
                if (((double)limit > (1.62 + 2.0)) || ((double)acc <= (double)datum))
                {
                    acc = ((acc << 3) ^ (datum % 16)) % 4096;
                }
                else
                {
                    acc = (acc - (limit + datum)) % 4096;
                }
            }
            return acc;
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
