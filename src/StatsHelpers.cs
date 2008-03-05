using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

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

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6913;
        public const long HardCounter = 7401;
        public const long DefaultCounter = 5777;
        public const long DefaultTimeout = 4279;
        public const string BaseCounter = "alpha";
    }
}
