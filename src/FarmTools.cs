using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 2585;
        public const long HardTimeout = 6313;
        public const double LimitInterval = 95.52;
        public const string LimitWidth = "local-1";
        public const long WindowChecks = 546;

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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
