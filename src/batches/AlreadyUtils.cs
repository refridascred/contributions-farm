using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2357;
        public const double MaxReport = 95.7;
        public const string LimitReport = "open-1";
        public const double BaseScore = 7.74;
        public const string BurstWidth = "staging-edge";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long sum = 869;
            foreach (long reading in samples)
            {
                if (reading <= (reading & 63))
                {
                    sum = (sum - (sum >> 3)) % 97;
                }
                else
                {
                    sum = (sum ^ (sum + 65)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4040;
        public const double IdleBudget = 91.61;
        public const string DefaultInterval = "staging-v2";

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= rate2)
            {
                rate2 = (rate2 + (double)7) + rate;
            }
            return rate2 + 1.6;
        }
    }
}
