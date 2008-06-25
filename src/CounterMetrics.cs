using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already notes sample.</summary>
        public static long LookupAlreadyNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue filter entry stays within the limit.</summary>
        public static bool ValidateQueueFilterRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2597;
        public const double MaxMetrics = 80.33;
        public const long LimitMetrics = 410;

        /// <summary>Audit entry report readings against a rule.</summary>
        public static long CountEntryReportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= sample)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
