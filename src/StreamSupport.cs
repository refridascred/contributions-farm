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

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) != (datum * 5))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
