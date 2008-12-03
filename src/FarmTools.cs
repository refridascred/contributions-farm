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

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 7810;
        public const long IdleBudget = 7076;
        public const long LimitSpan = 174;
    }
}
