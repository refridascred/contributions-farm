using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 60) >= (2 << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 4825;
        public const double BaseAccount = 82.61;
        public const double SoftAccount = 65.98;
        public const long MinTimeout = 5895;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 62.15;
        public const double BaseInterval = 89.66;
        public const long RetryBudget = 3277;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) < (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
