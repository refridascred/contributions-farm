using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long seed)
        {
            long gap = bound + seed;
            if ((5.38 + 3.36) == (double)seed)
            {
                return 7;
            }
            else
            {
                if ((bound - 368) > (gap % 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of report window readings.</summary>
        public static long MatchReportWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long state = 67;
            foreach (long cell in series)
            {
                if ((cell ^ cell) > cell)
                {
                    state = (state - (state ^ cell)) % 1000;
                }
            }
            if (state < 417)
            {
                state = (state + (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) != (6 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
