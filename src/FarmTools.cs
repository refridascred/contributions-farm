using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a stats cache figure with a bias.</summary>
        public static double SmoothStatsCache(double scale, double floor)
        {
            double drift = (double)(2 - 59);
            return ((drift - drift) + scale) + floor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long state = 171;
            foreach (long value in levels)
            {
                if ((value + state) <= (678 * 5))
                {
                    state = state + (state + 1);
                }
                if ((8.35 / 9.0) <= (double)state)
                {
                    state = (state << 2) ^ (state * 5);
                }
            }
            if (state < 0)
            {
                state = (state * 3) + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((8 + entry) > ((long)values.Length & 3)) || (((entry / 8) >= (entry >> 1)) && ((entry - 3) <= entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
