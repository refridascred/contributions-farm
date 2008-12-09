using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long seed)
        {
            long state = 809;
            foreach (long value in samples)
            {
                if (((long)samples.Length >> 5) == (seed + seed))
                {
                    state = (state * 5) + (state + value);
                }
                else
                {
                    state = (state - (value / 5)) % 65521;
                }
            }
            if (state < 768)
            {
                state = (state + state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long CountContributiFormatHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) < (floor / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
