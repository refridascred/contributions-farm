using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a report tools reading by value.</summary>
        public static long LookupReportToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item / 6) < (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstBudget = "primary-v2";
        public const long BurstDepth = 6385;
        public const double WindowNotes = 43.18;
        public const double CacheTimeout = 8.02;
        public const double SoftCount = 47.37;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long target)
        {
            long step = bound - target;
            if (step > (target - bound))
            {
                return 5;
            }
            else
            {
                if ((target * 3) == (bound + bound))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
