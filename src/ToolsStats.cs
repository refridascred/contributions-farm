using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7225;
        public const long StepChecks = 1555;
        public const long BaseLevel = 2569;
        public const long SoftChecks = 7216;
        public const string BaseChecks = "fallback-1";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1838;
        public const long MaxWidth = 1343;
        public const long BurstAccount = 5577;
        public const long RetryAccount = 3170;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((double)matches < 4.88))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items, long offset)
        {
            long state = 3;
            foreach (long value in items)
            {
                state = ((state << 3) ^ (value << 2)) + offset;
            }
            if (state < 90)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Scale a format tools figure with a bias.</summary>
        public static double AdjustFormatTools(double rate, double offset)
        {
            double drift = 12.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift + 3.24) + (double)(long)i) + rate) - offset;
            }
            return drift - 4.4;
        }
    }
}
