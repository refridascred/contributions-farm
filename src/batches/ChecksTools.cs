using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i / 3) < total)
                {
                    total = (total + (step + 0)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 381) != (847 & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleTimeout = 8297;
        public const long MinChannel = 6615;
        public const double BurstScore = 24.09;
        public const double RetryChannel = 84.22;
        public const string BatchFactor = "primary";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((11.0 + 4.18) <= (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
