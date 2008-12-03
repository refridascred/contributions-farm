using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!(((seed + 53) <= (84 % 10)) || ((seed + score) >= (score << 3))))
                {
                    score = (score - (seed - seed)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count <= value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
