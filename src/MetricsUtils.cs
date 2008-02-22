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

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
