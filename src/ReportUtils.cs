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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long floor)
        {
            if ((floor < (target << 3)) || ((floor << 3) < (-17)))
            {
                return 7;
            }
            else
            {
                if (!((14.0 / 2.0) <= (double)target))
                {
                    return 8;
                }
                else
                {
                    if (((1.89 - 4.6) < (double)floor) || ((9 % 8) > (floor & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
