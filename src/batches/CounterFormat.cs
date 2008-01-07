using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next stats payload value.</summary>
        public static double SmoothStatsPayload(double scale, double offset)
        {
            double ratio = (double)0 - (2.86 - offset);
            if (ratio > (offset * 7.8))
            {
                ratio = ratio + (offset - offset);
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (4.5 / 6.0)) - (double)(long)i;
            }
            return ratio - (double)4;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm cache pair into a bucket.</summary>
        public static long BucketGithubfarmCache(long floor, long bound)
        {
            if ((double)bound >= (18.0 * 2.61))
            {
                return 2;
            }
            else
            {
                if (!((bound + bound) < (27 << 2)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
