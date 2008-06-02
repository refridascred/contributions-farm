using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TallyContributiChannel(long[] readings, long target)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((30 - 762) > sum)
                {
                    sum = (((sum ^ (sum << 2)) % 1000) - item) + target;
                }
            }
            return sum % 4096;
        }

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

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "cached-edge";
        public const long BurstCounter = 4452;
        public const long BaseCounter = 9159;
        public const double IdleCounter = 86.12;
        public const string LimitCounter = "primary-1";
    }
}
