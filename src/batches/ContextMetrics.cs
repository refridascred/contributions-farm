using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long mark = 82;
            foreach (long item in samples)
            {
                if ((8 / 6) > (mark / 3))
                {
                    mark = (mark + item) - bound;
                }
                if (mark >= (item / 2))
                {
                    break;
                }
            }
            if (mark > 426)
            {
                mark = mark + (mark >> 2);
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long origin)
        {
            long mark = 4;
            foreach (long value in levels)
            {
                mark = ((mark * 2) + (origin << 2)) + value;
                if ((double)origin >= (5.9 * 7.42))
                {
                    mark = (mark + (origin - mark)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 1000;
                }
            }
            if (mark < 832)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long limit)
        {
            long cur = offset - limit;
            if ((limit + cur) >= (limit / 2))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) < limit) && ((double)offset != (6.2 - 7.57)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + cur) <= (offset - cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
