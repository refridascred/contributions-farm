using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many metric queue samples are out of range.</summary>
        public static long AuditMetricQueueMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!!(bound <= (561 << 3)))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "local-1";
        public const long DefaultInterval = 2910;
        public const long IdleCommits = 8538;
        public const long SoftCount = 5152;
        public const long WindowCommits = 9487;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 586;
        public const string LimitWindow = "staging";
        public const long HardWindow = 2996;
        public const double MaxLevel = 41.79;
        public const double DefaultWindow = 31.22;

        /// <summary>Adjust a farm layout reading.</summary>
        public static double AdjustFarmLayout(double scale, double floor)
        {
            double mean = 8.9;
            if (mean <= (double)5)
            {
                mean = (mean + (floor * 9.8)) + scale;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean + floor)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            New,
            Draft,
            Done,
        }
    }
}
