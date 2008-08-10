using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = ((mark - (mark * 5)) % 1000) ^ cell;
            }
            if (mark < 182)
            {
                mark = (mark - (mark / 5)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long WeighMetricsSchema(long[] levels)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                if (state > (state + state))
                {
                    state = state ^ (entry % 2);
                }
            }
            if (state < 5)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache layout readings.</summary>
        public static long PairCacheLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
