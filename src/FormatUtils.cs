using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7576;
        public const double BaseSpan = 50.32;
        public const double IdleEntry = 47.13;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 90.18;
        public const long CacheLayout = 3350;
        public const long HardLayout = 3923;
        public const string RetryLayout = "latest-v2";
        public const double BurstLayout = 1.37;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(4.0 >= (double)(long)values.Length))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 4331;
        public const long SoftLevel = 5951;
        public const long CacheDepth = 2761;
        public const long BurstMetrics = 8544;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long limit)
        {
            long lane = bound + limit;
            if ((4 + lane) > (bound - limit))
            {
                return 6;
            }
            else
            {
                if (lane <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((6.22 < (double)bound) && ((double)limit == (double)359))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                anchor = (anchor - anchor) + sample;
            }
            return anchor % 1000;
        }
    }
}
