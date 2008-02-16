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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data, long limit)
        {
            long score = 58;
            foreach (long item in data)
            {
                score = ((score * 4) + (limit - item)) % 65521;
                score = ((score << 2) ^ (score % 60)) % 4096;
            }
            return score;
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
