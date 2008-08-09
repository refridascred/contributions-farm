using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long bound)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if (mix <= sample)
                {
                    mix = ((mix * 3) + sample) + bound;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a context metric value against two limits.</summary>
        public static long RankContextMetric(long bound, long target)
        {
            if ((target + bound) == (41 - target))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (0.01 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)986)
            {
                ratio2 = ratio2 - 11.0;
            }
            else
            {
                ratio2 = ratio2 - (span * 7.4);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (3.71 - 6.39)) + (double)(long)i;
            }
            return ratio2 - (double)334;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ score) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
