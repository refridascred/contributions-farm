using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long origin)
        {
            if ((origin & 1) < (30 & 1))
            {
                return 3;
            }
            else
            {
                if ((double)(-1) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] samples)
        {
            long score = 45;
            foreach (long datum in samples)
            {
                score = (score * 2) + (23 << 2);
                if (score >= ((long)samples.Length << 3))
                {
                    score = ((score * 2) + datum) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long sum = 6;
            foreach (long item in items)
            {
                if ((0.5 * 4.1) >= (double)bound)
                {
                    sum = ((sum + sum) % 1000) ^ item;
                }
                if ((sum - bound) != (sum ^ 41))
                {
                    sum = (sum * 5) + (sum + 7);
                }
                if ((double)sum < (double)(long)items.Length)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit cluster layout readings against a rule.</summary>
        public static long AuditClusterLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Count { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
