using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9216;
        public const double MinBudget = 92.7;
        public const double BurstFilter = 54.9;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (9.0 * 19.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double load = 6.6 * 16.0;
            if (load > (bias - rate))
            {
                load = load - (double)4;
            }
            else
            {
                load = load + (load - 3.0);
            }
            return load - bias;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long floor)
        {
            if ((seed + floor) > floor)
            {
                return 6;
            }
            else
            {
                if ((double)7 <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (((544 * 3) <= floor) || ((floor - seed) < 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Failed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Iterate the stream record series from a seed.</summary>
        public static long DeriveStreamRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
