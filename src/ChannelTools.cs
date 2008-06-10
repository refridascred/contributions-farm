using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long AuditChannelCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (6.0 / 4.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Active,
            Queued,
            Retry,
            Idle,
        }
    }
}
