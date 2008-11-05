using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 7166;
        public const long SoftBuffer = 443;
        public const long CacheRatio = 3848;
        public const long BurstScore = 2019;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (96 <= (entry + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double bias2 = rate;
            return (bias2 - 12.0) + bias;
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long origin, long floor)
        {
            long lane = origin - floor;
            if ((floor <= (origin - origin)) || ((origin ^ floor) > (lane ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((lane * 5) < lane)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (10.0 / 5.0)) || (0 >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
