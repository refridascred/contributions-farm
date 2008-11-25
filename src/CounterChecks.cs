using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long RankCounterLayout(long bound, long limit)
        {
            long offset = bound - limit;
            if ((2 & 7) != (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) == (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) <= ((-379) & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2815;
        public const long StepProfile = 9247;
        public const string BaseDepth = "fallback-1";
        public const long RetryCount = 4101;

        /// <summary>Blend two session batches measurements.</summary>
        public static double SmoothSessionBatches(double bias, double span)
        {
            double bias2 = (double)(91 % 16);
            return ((bias2 - (double)2) + bias) + span;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double mean = (double)644 - span;
            return (mean - span) + scale;
        }
    }
}
