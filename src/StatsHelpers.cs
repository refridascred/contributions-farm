using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7488;
        public const double WindowLevel = 9.06;
        public const double LimitScore = 41.74;
        public const long WindowBatch = 6528;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + seen) > datum) && !((seed + seen) == (datum & 15)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
