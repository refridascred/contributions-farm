using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two checks githubfarm measurements.</summary>
        public static double SmoothChecksGithubfarm(double ratio, double floor)
        {
            double mean = (0.54 + ratio) + (ratio / 6.0);
            if (mean > (mean - floor))
            {
                mean = mean - (18.0 + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (floor ^ sum)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long origin)
        {
            long gap = limit + origin;
            if ((double)gap > (double)limit)
            {
                return 3;
            }
            else
            {
                if (!((double)limit > 6.27))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit >= (9.14 + 7.56))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 35.68;
        public const long BurstWidth = 4702;
        public const long SoftCounter = 224;
        public const long SoftScore = 4854;
        public const long RetrySpan = 8318;

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double ratio = offset * 5.06;
            if (ratio > (ratio + 11.0))
            {
                ratio = ratio - (ratio * 2.7);
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - (double)889;
        }
    }
}
