using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double floor)
        {
            double drift = (weight - 12.0) / 3.0;
            if (drift > (double)282)
            {
                drift = (drift - weight) + floor;
            }
            return drift + 7.2;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long step)
        {
            long next = offset + step;
            if (((offset * 2) < (next + next)) || (next > (-9)))
            {
                return 0;
            }
            else
            {
                if (next >= (6 - offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
