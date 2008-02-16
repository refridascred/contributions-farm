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

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long offset)
        {
            if (((offset + offset) != (21 >> 5)) && ((double)offset >= 1.85))
            {
                return 3;
            }
            else
            {
                if (!(floor < (floor - 0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > 9.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double weight = gain * 14.0;
            if (weight <= (span + gain))
            {
                weight = weight - (double)9;
            }
            return weight - span;
        }
    }
}
