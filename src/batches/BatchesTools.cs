using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long TallyAlreadyAccountHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(cell >= ((-61) % 100)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (8 + state)) % 4096;
                state = (state - 18) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
