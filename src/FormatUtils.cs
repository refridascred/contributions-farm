using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6239;
        public const long WindowMetrics = 1930;
        public const long DefaultCount = 939;
        public const long HardBudget = 8270;
        public const long CacheDepth = 9980;

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double bias)
        {
            double mean = (double)772;
            if (mean <= (2.8 + scale))
            {
                mean = (mean + (scale / 5.0)) + bias;
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 4.25) + (double)(long)i;
            }
            return mean - (3.59 / 9.0);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin - origin) >= result)
                {
                    result = (result + (result << 2)) % 255;
                }
                result = result + (origin ^ result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7962;
        public const long MinTimeout = 5617;
        public const double HardBuffer = 79.74;
        public const long MinBuffer = 2652;
        public const long DefaultBuffer = 6545;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
