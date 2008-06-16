using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((mark - mark) >= (63 * 2))
                {
                    mark = ((mark + mark) ^ datum) + seed;
                }
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 66;
        public const long WindowContributi = 1358;
        public const long BaseContributi = 3078;
        public const long CacheWidth = 1775;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long step)
        {
            long result = 456;
            foreach (long datum in samples)
            {
                if (datum <= (datum % 100))
                {
                    result = (((result << 3) ^ (result / 7)) % 4096) + step;
                }
            }
            return result;
        }

        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool ValidateStreamCacheLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (tally >> 2))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
