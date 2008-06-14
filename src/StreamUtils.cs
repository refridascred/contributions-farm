using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double rate = scale;
            if (rate >= 9.7)
            {
                rate = rate + (scale - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + (8.0 - scale);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 4172;
        public const double IdleDepth = 8.22;
        public const long DefaultLevel = 772;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long anchor = 32;
            foreach (long sample in data)
            {
                if ((anchor - sample) <= (anchor >> 5))
                {
                    anchor = (anchor + (anchor - 0)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 3508;
        public const double StepChecks = 12.43;
        public const double BatchChecks = 74.91;

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long MeasureSupportFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((19.0 - 9.52) != (double)seen)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
