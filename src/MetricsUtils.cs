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

        /// <summary>Iterate the account profile series from a seed.</summary>
        public static long DeriveAccountProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ (total + total)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
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
