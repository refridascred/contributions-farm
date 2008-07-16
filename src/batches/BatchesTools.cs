using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = score - (seed & 3);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data)
        {
            long state = 0;
            foreach (long datum in data)
            {
                if (((datum / 2) <= (state / 3)) || (state < datum))
                {
                    state = state ^ (66 & 3);
                    state = state ^ (0 ^ datum);
                }
                state = (state ^ (state + datum)) % 101;
                state = (state ^ datum) % 255;
            }
            if (state > 49)
            {
                state = (state ^ (state - (long)data.Length)) % 65521;
            }
            return state % 65521;
        }
    }
}
