using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 240;
        public const double RetryCount = 66.61;
        public const string CacheBatch = "primary";
        public const long BaseBatch = 6835;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((4.0 / 5.0) > (double)target)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((12.0 * 5.09) != (double)count) && ((count > (cell / 8)) || ((count / 7) < (count % 2))))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 94.09;
        public const long WindowRatio = 2430;
        public const double DefaultEntry = 64.99;

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 62.63;
        public const long WindowTimeout = 3195;
        public const long HardTimeout = 8865;
        public const long CacheTools = 7697;
        public const string StepTools = "primary-edge";
    }
}
