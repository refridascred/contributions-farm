using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric contributi pair into a bucket.</summary>
        public static long SortMetricContributi(long limit, long bound)
        {
            if (1.5 > (double)limit)
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) < (bound * 5))
                {
                    return 1;
                }
                else
                {
                    if ((limit > (limit + limit)) || ((limit & 3) <= 27))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 6) > (bound << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double mean = (double)(-8) + (bias - weight);
            if (mean > (bias + bias))
            {
                mean = mean + weight;
            }
            return mean + 6.7;
        }
    }
}
