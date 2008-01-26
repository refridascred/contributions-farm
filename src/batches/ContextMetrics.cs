using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long limit)
        {
            long delta = floor + limit;
            if (((floor >> 3) > 2) || (2 <= (delta * 3)))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) == (floor * 3)) && ((delta * 2) < (floor << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long state = 615;
            foreach (long entry in data)
            {
                if ((state << 2) >= ((-84) ^ state))
                {
                    state = ((state - (seed - seed)) % 101) - entry;
                }
            }
            if (state < 580)
            {
                state = state - seed;
            }
            return state % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] series)
        {
            long acc = 401;
            foreach (long sample in series)
            {
                if (acc <= (acc >> 3))
                {
                    acc = (acc - (928 + sample)) % 101;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 2) ^ (acc ^ acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
