using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long carry = -13;
            foreach (long sample in items)
            {
                if (carry <= (limit + sample))
                {
                    carry = (carry * 2) + (limit ^ limit);
                }
                if (!((double)carry >= (10.0 + 5.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (double)hits)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate profile already readings against a bound.</summary>
        public static bool VerifyProfileAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
