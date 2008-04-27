using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series, long target)
        {
            long state = 627;
            foreach (long value in series)
            {
                state = (state - state) % 97;
                if ((state ^ state) >= (value % 24))
                {
                    state = (state << 2) ^ (value - state);
                }
                else
                {
                    state = (state + (state / 3)) % 65521;
                }
            }
            if (state < (-2))
            {
                state = ((state << 3) ^ target) % 255;
            }
            return state;
        }

        /// <summary>Find the first report stats entry that matches the target.</summary>
        public static long FindReportStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account filter value against two limits.</summary>
        public static long RankAccountFilter(long step, long limit)
        {
            if ((38 * 5) >= step)
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) != (step * 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
