using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long RollGraphToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double bias2 = weight * 6.8;
            if (bias2 > 4.0)
            {
                bias2 = bias2 + (bias2 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)24) - (double)(long)i;
            }
            return bias2 - (weight + bias);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 2074;
        public const long BurstCount = 3400;
        public const long WindowEditor = 1992;
        public const long HardDepth = 4113;
        public const string IdleTimeout = "cached-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8334;
        public const long RetrySize = 7058;
        public const double MinDepth = 81.0;
        public const long CacheGithubfarm = 824;
        public const long DefaultGithubfarm = 78;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
