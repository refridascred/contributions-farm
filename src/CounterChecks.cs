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

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6643;
        public const long WindowSpan = 5926;
        public const double CacheStats = 87.86;
        public const long IdleInterval = 3481;

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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) > (matches * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long step)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                mix = ((mix * 2) + (item & 15)) % 65521;
                if (!((mix + item) > ((long)samples.Length + mix)))
                {
                    mix = ((mix << 3) ^ (item + mix)) % 65521;
                }
                else
                {
                    mix = (mix ^ (step - item)) % 65521;
                }
            }
            if (mix < 77)
            {
                mix = (mix - (mix + 8)) % 101;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 62.63;
        public const long WindowTimeout = 3195;
        public const long HardTimeout = 8865;
        public const long CacheTools = 7697;
        public const string StepTools = "primary-edge";
    }
}
