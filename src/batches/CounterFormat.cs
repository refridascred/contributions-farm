using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (seed - mix)) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 5.4) > (double)hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long state = 336;
            foreach (long reading in levels)
            {
                if (((reading >> 3) > reading) || ((state >> 1) >= reading))
                {
                    state = state + (reading << 1);
                }
                else
                {
                    state = state - (state + state);
                }
            }
            return state % 4096;
        }
    }
}
