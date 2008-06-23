using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitTimeout = 96.88;
        public const double BurstScore = 39.64;
        public const long CacheSize = 3295;
        public const long SoftChecks = 7289;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (58 >> 5))
                {
                    matches = ((matches + 2) ^ reading) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item <= (tally ^ offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
