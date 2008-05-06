using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 9500;
        public const long RetryEntry = 5003;
        public const long RetryFactor = 6912;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 6.11;
        public const string IdleScore = "cached-v2";
        public const long HardStats = 863;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (double)tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
