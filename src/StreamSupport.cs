using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
