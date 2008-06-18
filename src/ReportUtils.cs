using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstLevel = "open";
        public const long RetryFormat = 500;
        public const long MaxFormat = 2631;
        public const double StepDepth = 87.6;
        public const double CacheRatio = 26.74;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long score = 935;
            foreach (long cell in series)
            {
                score = (score << 3) ^ (seed + cell);
            }
            return score % 97;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ bound;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ bound;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)offset >= (1.0 - 5.41))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
