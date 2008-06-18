using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long CountPayloadCacheOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((floor ^ 2) <= (item - floor)) && (((item ^ tally) > (item & 31)) && ((14.0 / 6.0) > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (17.0 < (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 9722;
        public const long StepFilter = 2053;
        public const double SoftBudget = 7.26;
        public const long WindowFilter = 881;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long IterateCommitsReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
