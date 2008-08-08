using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long result = 2;
            foreach (long datum in samples)
            {
                result = (result << 3) ^ (bound / 8);
                if (((2.2 * 3.8) < (double)bound) || (0.2 <= (double)datum))
                {
                    result = ((result * 5) + (datum + bound)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                if ((double)origin < (1.93 * 0.5))
                {
                    mark = (((mark << 2) ^ (mark + origin)) % 4096) + cell;
                }
            }
            if (mark < 415)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8499;
        public const long HardGithubfarm = 8610;
        public const long MinFactor = 4182;
        public const double LimitLevel = 83.18;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
