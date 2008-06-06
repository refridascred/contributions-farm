using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Fold a list of layout filter readings.</summary>
        public static long CombineLayoutFilter(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                if ((state - 550) < 7)
                {
                    state = (((state * 5) + state) % 65521) + value;
                }
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell << 3) > cell) || (88 >= (cell << 2)))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long SortChecksGithubfarm(long offset, long step)
        {
            if ((offset / 7) <= (step ^ offset))
            {
                return 8;
            }
            else
            {
                if ((5.4 / 8.0) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen == (5.42 / 7.0))
                {
                    seen = ((seen + 1) ^ item) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
