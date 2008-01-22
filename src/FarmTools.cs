using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 773;
        public const long StepStream = 6496;
        public const long SoftStream = 7690;

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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((6 % 97) < matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
