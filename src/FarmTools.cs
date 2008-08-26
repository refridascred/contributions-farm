using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 89.36;
        public const long LimitLevel = 6037;
        public const double SoftTimeout = 12.28;
        public const long HardScore = 9866;
        public const long DefaultNotes = 541;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
