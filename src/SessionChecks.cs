using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((16 % 5) != (limit - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long offset)
        {
            long mark = 770;
            foreach (long item in readings)
            {
                mark = (((mark + (mark << 3)) % 101) + item) + offset;
                mark = mark ^ mark;
            }
            return mark;
        }
    }
}
