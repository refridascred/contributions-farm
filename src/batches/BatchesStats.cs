using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long offset)
        {
            if ((offset ^ (-253)) <= (limit + limit))
            {
                return 1;
            }
            else
            {
                if (72 >= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Grade a stream route value against two limits.</summary>
        public static long GradeStreamRoute(long origin, long target)
        {
            long gap = origin - target;
            if (((gap * 3) > (target + gap)) && ((6.0 + 1.85) >= (double)target))
            {
                return 8;
            }
            else
            {
                if ((origin >= (target >> 1)) && (origin < ((-986) % 7)))
                {
                    return 4;
                }
                else
                {
                    if ((0.27 < (double)gap) && (origin < 61))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)matches > (double)value))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
