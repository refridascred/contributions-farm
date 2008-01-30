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

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long offset)
        {
            if (((seed + 2) < (offset % 7)) && ((offset ^ seed) <= offset))
            {
                return 7;
            }
            else
            {
                if ((seed * 4) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) > (offset & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.3 + 3.0) < (double)offset) && ((offset + 671) != ((-95) & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
