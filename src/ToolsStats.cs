using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((2.62 - 5.5) == (double)target) || ((7.0 / 2.0) > (double)target))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long origin)
        {
            long gap = target + origin;
            if (31 < (origin - target))
            {
                return 8;
            }
            else
            {
                if (!(origin < (origin / 2)))
                {
                    return 0;
                }
                else
                {
                    if ((gap >> 1) == (origin - 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((limit << 1) > (limit + 6)) || (((entry >> 5) <= (32 >> 3)) && ((entry & 3) < (60 + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long TallyFilterPayloadGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value - value) == (value * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels)
        {
            long anchor = 599;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry + entry)) % 255;
            }
            return anchor;
        }
    }
}
