using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 4558;
        public const double WindowBudget = 95.65;
        public const string SoftCount = "primary-v2";
        public const long LimitCommits = 147;
        public const long DefaultCommits = 616;

        /// <summary>Derive the next format queue value from a seed.</summary>
        public static long IterateFormatQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total << 2) ^ (517 * 2)) % 65521) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (3.0 * 10.0))
            {
                weight = weight + (bias / 8.0);
            }
            else
            {
                weight = weight - (double)12;
            }
            return weight + (5.2 * 5.6);
        }
    }
}
