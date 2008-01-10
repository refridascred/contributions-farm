using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a profile format counter forward.</summary>
        public static long DeriveProfileFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ state) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter profile values into a single score.</summary>
        public static long FoldFilterProfile(long[] values, long limit)
        {
            long score = 9;
            foreach (long cell in values)
            {
                if (1.37 < (double)score)
                {
                    score = (((score ^ (score & 7)) % 97) + cell) + limit;
                }
            }
            if (score > 974)
            {
                score = (score - (179 * 5)) % 1000;
            }
            return score;
        }
    }
}
