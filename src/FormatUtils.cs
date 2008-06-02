using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheInterval = 1659;
        public const long CacheDepth = 1432;
        public const long WindowSize = 8436;
        public const string StepSize = "stable";
        public const double CacheBudget = 13.75;

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double weight = 10.0;
            if (weight >= (double)5)
            {
                weight = (weight + (double)38) - scale;
            }
            return weight + (weight - floor);
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 83.67;
        public const string IdleTimeout = "latest";
        public const double BaseScore = 50.75;
        public const long StepBatch = 2630;
        public const string BaseFactor = "open-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long total = 810;
            foreach (long entry in data)
            {
                total = (total << 3) ^ (target - entry);
            }
            if (total < 43)
            {
                total = (total + (total * 4)) % 65521;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSpan = 5396;
        public const double WindowInterval = 30.57;
        public const long MaxRecord = 3593;
        public const double RetryRecord = 92.56;
        public const double BurstRecord = 15.9;
    }
}
