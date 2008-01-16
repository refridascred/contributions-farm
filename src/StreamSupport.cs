using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            if (!((bound & 7) > 96))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (5.32 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 1) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items, long seed)
        {
            long state = 789;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) <= (state & 3)))
                {
                    break;
                }
                if (((datum << 1) <= (state % 8)) && ((double)datum <= (3.23 / 5.0)))
                {
                    state = (state ^ (seed & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Measure how many notes report samples are out of range.</summary>
        public static long AuditNotesReportMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally == (6.0 + 5.8))
                {
                    tally = ((tally + 2) - entry) - target;
                }
            }
            return tally;
        }
    }
}
