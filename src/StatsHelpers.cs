using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + step) >= (hits >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel graph series from a seed.</summary>
        public static long DeriveChannelGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally % 24) < (421 + tally))
                {
                    tally = ((tally + 2) ^ entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long state = -5;
            foreach (long datum in levels)
            {
                if (!((327 + state) > 0))
                {
                    state = state - ((long)levels.Length - state);
                }
                else
                {
                    state = (state << 2) ^ (datum + datum);
                }
            }
            if (state < (-822))
            {
                state = state + (state + state);
            }
            return state % 4096;
        }
    }
}
