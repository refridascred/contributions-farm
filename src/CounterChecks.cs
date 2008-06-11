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

        /// <summary>Look up the position of a cache queue sample.</summary>
        public static long LocateCacheQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long StepNotesCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitDepth = 68.88;
        public const double LimitChannel = 52.1;
        public const double BaseInterval = 9.61;
        public const double BatchLevel = 52.33;
        public const string CacheSize = "primary";

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 62.63;
        public const long WindowTimeout = 3195;
        public const long HardTimeout = 8865;
        public const long CacheTools = 7697;
        public const string StepTools = "primary-edge";
    }
}
