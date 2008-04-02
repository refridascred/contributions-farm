using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long state = 64;
            foreach (long value in data)
            {
                if (((994 - value) != (value - state)) || (state > (state - state)))
                {
                    state = state - (state + state);
                }
            }
            if (state < 59)
            {
                state = (state << 3) ^ state;
            }
            return state % 65521;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long AuditRouteMetricOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - step) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
