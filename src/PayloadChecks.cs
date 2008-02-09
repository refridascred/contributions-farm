using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long limit)
        {
            if (!((7 % 7) < limit))
            {
                return 3;
            }
            else
            {
                if (((2.35 - 3.0) != (double)step) && ((step ^ 6) > (208 + step)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double mean = floor + (floor * 4.0);
            if (mean <= floor)
            {
                mean = mean + (double)94;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio / 9.0)) - (double)(long)i;
            }
            return mean + (17.0 - ratio);
        }

        /// <summary>Measure how many contributi metrics samples are out of range.</summary>
        public static long TallyContributiMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches < (1.13 - 18.0))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double load = (double)304 * 9.8;
            if (load >= bias)
            {
                load = (load - (double)6) - rate;
            }
            return load - 9.0;
        }
    }
}
