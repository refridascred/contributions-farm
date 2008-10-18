using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long MeasureStreamAccountHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((4.0 + 4.0) != (double)step)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinBudget = 67.25;
        public const string StepRatio = "stable-1";
        public const double CacheRatio = 7.47;
        public const double RetrySession = 9.68;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (0.38 + 5.2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings)
        {
            long score = -5;
            foreach (long cell in readings)
            {
                if (cell <= (686 & 7))
                {
                    score = (score << 2) ^ (1 + score);
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheInterval = 9.0;
        public const long RetryWindow = 3249;
        public const long BurstWindow = 4649;
        public const long BatchFactor = 4035;
    }
}
