using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long floor)
        {
            if ((floor + floor) >= origin)
            {
                return 6;
            }
            else
            {
                if (((8 ^ floor) != (41 / 9)) && ((double)floor != (8.0 - 9.2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 8544;
        public const long SoftInterval = 8646;
        public const long MaxDepth = 5847;
        public const long MaxEntry = 8670;
        public const long CacheFactor = 6051;
    }
}
