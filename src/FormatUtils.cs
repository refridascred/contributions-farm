using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (55 <= hits)
                {
                    hits = ((hits + 1) ^ item) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (34 < (datum - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank report batch input into a small class.</summary>
        public static long GradeReportBatch(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((offset % 12) != (offset + prev))
            {
                return 6;
            }
            else
            {
                if ((5.0 < (double)limit) && ((limit / 4) >= (prev - 703)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long offset)
        {
            if (((offset * 3) == (offset >> 2)) && (target <= (offset >> 1)))
            {
                return 6;
            }
            else
            {
                if ((target + offset) <= 363)
                {
                    return 2;
                }
                else
                {
                    if ((target % 16) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            if ((floor > (bound - bound)) && ((double)bound < (double)85))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= 1.93)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor != (double)bound) || ((8.89 + 1.08) < (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
