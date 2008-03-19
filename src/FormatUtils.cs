using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)target <= 19.0)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((74 + seed) <= ((long)i & 15))
                {
                    score = ((score * 5) + (score + (long)i)) % 255;
                }
                score = score + seed;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Ready,
            New,
            Failed,
            Locked,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item >= (27 - 652)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
