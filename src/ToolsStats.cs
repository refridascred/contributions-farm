using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepWidth = 6810;
        public const long MaxTimeout = 9166;
        public const long CacheTimeout = 3798;
        public const long CacheCluster = 8857;
        public const long LimitCluster = 7122;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item & 63) <= (item & 1)) && ((seen * 4) >= 287))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long result = 857;
            foreach (long item in levels)
            {
                result = (result + (item + item)) % 4096;
                result = (result << 2) ^ (item / 8);
            }
            return result % 4096;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            New,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool VerifyCommandBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
