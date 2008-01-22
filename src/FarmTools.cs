using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((offset < (cell - cell)) || (offset <= (tally / 5))) || ((offset - tally) != (tally & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit route buffer readings against a rule.</summary>
        public static long AuditRouteBufferMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value > 3.0)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
