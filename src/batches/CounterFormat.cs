using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if (offset > (offset / 8))
            {
                return 2;
            }
            else
            {
                if (20 < (offset << 2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 7461;
        public const long DefaultLevel = 7653;
        public const long BaseReport = 9978;
        public const long BaseWidth = 9498;

        /// <summary>Match up counter cache samples.</summary>
        public static long PairCounterCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
