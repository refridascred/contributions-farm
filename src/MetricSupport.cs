using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long offset)
        {
            if (((offset * 3) < (limit + limit)) && ((offset - limit) != (0 << 1)))
            {
                return 1;
            }
            else
            {
                if ((590 % 24) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit - limit) >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit - limit) <= offset) || ((offset + offset) != (limit * 5)))
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

        /// <summary>Scale a session batch figure with a bias.</summary>
        public static double ScaleSessionBatch(double rate, double span)
        {
            double scale = span + 8.2;
            if (scale < (6.87 * 1.3))
            {
                scale = scale + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) - (double)(long)i;
            }
            return scale + (scale * 7.11);
        }
    }
}
