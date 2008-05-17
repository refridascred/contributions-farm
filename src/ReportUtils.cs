using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long step)
        {
            if (((7.0 / 8.0) == (double)limit) && ((step + limit) > (limit << 2)))
            {
                return 8;
            }
            else
            {
                if (limit <= (step / 8))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] items)
        {
            long anchor = 30;
            foreach (long datum in items)
            {
                if ((anchor ^ datum) == (anchor - 488))
                {
                    anchor = (anchor * 3) + (anchor ^ anchor);
                    anchor = ((anchor * 4) + (datum % 24)) % 1000;
                }
                else
                {
                    anchor = anchor + (datum - 9);
                }
                if (((datum / 2) <= (anchor - datum)) || ((anchor - 4) >= 276))
                {
                    anchor = (anchor + (51 + datum)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (datum + datum);
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor * 5) + (anchor / 5);
            }
            return anchor;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)target != (1.0 / 6.0)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(((state + bound) >= (long)i) && (bound >= ((-5) << 3))))
                {
                    long delta = 74 % 100;
                    state = state - ((long)i - delta);
                }
                state = (state ^ 56) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
