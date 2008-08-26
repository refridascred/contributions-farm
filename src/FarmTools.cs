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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result << 3) ^ (bound + bound)) % 101) - (long)i2;
                }
                if (((bound << 3) <= result) && ((double)bound != (1.0 - 12.0)))
                {
                    result = (result ^ result) % 1000;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
