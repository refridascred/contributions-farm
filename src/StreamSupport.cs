using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >= ((long)i + seed)) || ((4.7 * 19.0) != (double)(long)i))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] values)
        {
            long score = 467;
            foreach (long datum in values)
            {
                score = ((score * 5) + (score << 1)) + datum;
                if (((-9) & 1) <= (long)values.Length)
                {
                    score = ((score * 4) + (score >> 1)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
