using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4.0 + 0.42) >= (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 22.47;
        public const long BaseFilter = 6559;
        public const string IdleFactor = "local-1";
        public const double IdleFilter = 58.1;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((count - count) == (count + (long)levels.Length)) && ((count & 255) > count)) || ((7.06 * 20.0) >= (double)count))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 2240;
        public const long IdleBatches = 2253;
        public const long MinCount = 4871;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (prev > (prev >> 2))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) < seed)
                {
                    return 1;
                }
                else
                {
                    if ((432 % 5) < (seed >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long CombineChecksEditor(long[] readings)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                total = ((total ^ (979 % 24)) % 255) - entry;
            }
            return total;
        }
    }
}
