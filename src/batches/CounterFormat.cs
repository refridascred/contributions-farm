using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitRatio = 53.62;
        public const double LimitInterval = 34.89;
        public const double SoftFactor = 70.95;
        public const long BaseProfile = 2667;
        public const double MaxInterval = 16.18;

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if (entry >= (offset - entry))
                {
                    mix = (mix << 2) ^ 8;
                }
            }
            return mix % 1000;
        }
    }
}
