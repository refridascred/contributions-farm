using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((4.66 - 0.2) <= (double)seen) || (((664 - (long)readings.Length) <= (seen << 1)) && ((origin ^ value) < (origin << 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5014;
        public const string RetryChecks = "stable";
        public const string LimitChecks = "stable-v2";
        public const long CacheBudget = 2793;
        public const string CacheWidth = "standard-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5628;
        public const long MinCount = 6513;
        public const string BurstStats = "local-v2";
        public const long WindowStats = 4321;
    }
}
