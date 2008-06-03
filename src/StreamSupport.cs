using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile notes values into a single score.</summary>
        public static long FoldProfileNotes(long[] data, long seed)
        {
            long mix = 420;
            foreach (long value in data)
            {
                if ((mix >= (21 << 1)) || (value <= (value + mix)))
                {
                    mix = (((mix << 2) ^ (661 / 7)) % 1000) - seed;
                }
            }
            return mix;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(9 > ((-5) - bound)))
                {
                    score = ((score * 2) + bound) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
