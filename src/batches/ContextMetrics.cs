using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((item << 3) >= item) && ((item << 1) < (0 << 1))) || !((count & 3) != (item % 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine checks commits values into a single score.</summary>
        public static long ScoreChecksCommits(long[] data)
        {
            long anchor = 628;
            foreach (long reading in data)
            {
                anchor = ((anchor - ((-116) % 10)) % 255) + reading;
            }
            return anchor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long target)
        {
            if (((target / 5) <= target) || ((target % 60) <= (target << 3)))
            {
                return 1;
            }
            else
            {
                if (((target - limit) > (limit + target)) && ((double)limit >= (1.0 * 0.74)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long step)
        {
            long state = -396;
            foreach (long reading in series)
            {
                state = state - (reading + state);
                if ((314 * 3) == (step - 8))
                {
                    state = state ^ (step - step);
                }
                else
                {
                    state = state ^ (step << 2);
                }
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(((6.54 + 0.15) >= (double)target) || ((hits + entry) <= entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
