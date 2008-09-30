using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits > (hits << 3))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (54 > (46 - entry))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryScore = 7896;
        public const long StepCache = 4762;
        public const double RetryCache = 47.8;
        public const string DefaultInterval = "alpha";
        public const long HardCache = 3591;

        /// <summary>Validate token already readings against a bound.</summary>
        public static bool CheckTokenAlreadyBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
