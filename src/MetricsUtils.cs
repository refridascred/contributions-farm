using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long bound)
        {
            if ((offset + offset) > (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) <= (-21))
                {
                    return 5;
                }
                else
                {
                    if (!((1.85 - 3.1) > (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((20 - cell) < (tally << 2)) && ((tally & 127) > (tally >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3207;
        public const long StepTimeout = 5090;
        public const string HardSpan = "alpha-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 6075;
        public const double MaxCount = 34.08;
        public const string BatchSpan = "latest-v2";
        public const long RetryFactor = 2822;

        /// <summary>Classify a commits layout pair into a bucket.</summary>
        public static long GradeCommitsLayout(long target, long seed)
        {
            if (((target + target) <= target) || (target >= (target + seed)))
            {
                return 7;
            }
            else
            {
                if (seed <= 537)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
