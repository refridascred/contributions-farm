using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "cached-v2";
        public const double BurstRatio = 25.2;
        public const string IdleStream = "alpha-edge";
        public const long BatchCount = 4858;
        public const long MaxFactor = 9923;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((step - step) <= (sample - step)) && ((hits + 5) < (hits + hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally % 5) < sample)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
