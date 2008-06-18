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

        /// <summary>Rank profile buffer input into a small class.</summary>
        public static long ClassifyProfileBuffer(long offset, long bound)
        {
            if ((bound - bound) >= bound)
            {
                return 2;
            }
            else
            {
                if (((offset + bound) <= (offset + offset)) || (((-97) & 31) < bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
