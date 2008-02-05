using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(reading >= (reading & 127)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 56;
            foreach (long entry in levels)
            {
                if (entry <= (state - entry))
                {
                    state = (state << 3) ^ (state / 5);
                }
            }
            if (state < 969)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
