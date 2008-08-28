using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "staging";
        public const double MaxCount = 95.88;
        public const long BurstCounter = 3129;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((5.0 - 3.0) != (double)seed) && !((double)reading <= 9.5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
