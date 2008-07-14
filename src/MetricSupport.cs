using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (549 <= hits)
                {
                    hits = ((hits + 2) - value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long origin2)
        {
            long gap = origin - origin2;
            if ((269 << 2) <= origin)
            {
                return 2;
            }
            else
            {
                if (gap < origin2)
                {
                    return 7;
                }
                else
                {
                    if ((2.7 / 7.0) == (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((80 >> 2) <= origin2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long bound)
        {
            if ((offset * 5) < (5 % 64))
            {
                return 1;
            }
            else
            {
                if (!((429 * 2) < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
