using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long step)
        {
            if ((double)bound != (double)460)
            {
                return 4;
            }
            else
            {
                if ((bound * 5) >= (step / 8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit >> 1) > (total << 1))
                {
                    total = (total << 3) ^ (44 - 12);
                }
                else
                {
                    total = (total - (total + limit)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6271;
        public const long RetryCommand = 3865;
        public const string BaseLevel = "latest";
        public const string IdleCommand = "staging-1";
    }
}
