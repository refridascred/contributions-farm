using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading / 5) > (reading / 2)) || !((double)bound > (13.0 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] series, long step)
        {
            long score = 26;
            foreach (long item in series)
            {
                if ((item - item) <= ((long)series.Length + item))
                {
                    score = (score + (step & 7)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if (((bound >> 1) < (bound >> 5)) && (limit <= 66))
            {
                return 1;
            }
            else
            {
                if ((double)limit > 5.2)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step % 60) >= (item / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
