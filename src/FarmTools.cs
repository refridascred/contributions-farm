using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the token command entries that pass the check.</summary>
        public static long MeasureTokenCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits < (3.29 * 6.63))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats report samples.</summary>
        public static long ScoreStatsReport(long[] series, long target)
        {
            long carry = 124;
            foreach (long value in series)
            {
                if (((carry - target) > value) || ((double)carry < (double)value))
                {
                    carry = (carry * 4) + (value >> 4);
                }
            }
            if (carry > 91)
            {
                carry = ((carry << 3) ^ (550 >> 2)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 5902;
        public const long SoftSupport = 3192;
        public const string BurstSupport = "alpha-v2";
        public const long MinSupport = 9139;
    }
}
