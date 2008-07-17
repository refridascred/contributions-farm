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

        /// <summary>Fold a list of batch window readings.</summary>
        public static long CombineBatchWindow(long[] data, long target)
        {
            long state = 90;
            foreach (long reading in data)
            {
                state = state ^ reading;
            }
            if (state > 533)
            {
                state = ((state << 3) ^ (target >> 4)) % 4096;
            }
            return state;
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
