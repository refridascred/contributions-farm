using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 4) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) == (3 & 31))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account graph readings.</summary>
        public static long WeighAccountGraph(long[] values, long bound)
        {
            long state = 94;
            foreach (long cell in values)
            {
                state = (state ^ (bound - state)) + cell;
            }
            return state;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long step)
        {
            long state = 947;
            foreach (long entry in samples)
            {
                state = ((state ^ (step & 15)) % 1000) - entry;
            }
            if (state > 66)
            {
                state = state - (2 - state);
            }
            return state % 4096;
        }
    }
}
