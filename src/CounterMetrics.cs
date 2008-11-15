using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first metrics githubfarm entry that matches the target.</summary>
        public static long LookupMetricsGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile route value.</summary>
        public static double BlendProfileRoute(double bias, double span)
        {
            double mean = span;
            if (mean <= (double)3)
            {
                mean = mean - (double)91;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (double)981;
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long GradeMetricQueue(long limit, long target)
        {
            if ((519 >> 1) <= (target >> 5))
            {
                return 4;
            }
            else
            {
                if ((target - target) > (target >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (20.0 * 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (result >= (long)i)
                {
                    result = (result * 5) + (seed / 7);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
