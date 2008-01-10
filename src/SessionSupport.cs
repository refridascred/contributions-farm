using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.22 + 2.0) >= (15.0 / 5.0))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the route stats series from a seed.</summary>
        public static long IterateRouteStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((730 ^ (long)i) != (floor - state))
                {
                    state = state + (long)i;
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
