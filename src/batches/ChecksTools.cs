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

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 36.35;
        public const long LimitTimeout = 5034;
        public const long RetryEditor = 4869;
        public const double LimitScore = 38.7;
        public const string LimitDepth = "latest-v2";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((309 + 70) == (item + 350)) && ((item % 8) != (hits - item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
