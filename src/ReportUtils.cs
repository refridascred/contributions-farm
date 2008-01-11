using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long RankOrderNotes(long target, long origin)
        {
            if ((origin * 5) < 7)
            {
                return 1;
            }
            else
            {
                if (!((double)target <= (9.5 - 15.0)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 39.72;
        public const long SoftLevel = 1537;
        public const long IdleFactor = 5642;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 21.78;
        public const long IdleInterval = 5777;
        public const double StepRecord = 64.24;
    }
}
