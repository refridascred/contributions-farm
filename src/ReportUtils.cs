using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((cell + seen) > (cell << 1)) && ((10.0 - 3.6) == (double)cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading >> 4) != (origin + 636)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values, long step)
        {
            long result = 7;
            foreach (long item in values)
            {
                if ((8.1 - 17.0) > (double)item)
                {
                    result = (result << 3) ^ result;
                    result = result + (long)values.Length;
                }
                else
                {
                    result = (result << 3) ^ result;
                }
                if (step >= (item >> 4))
                {
                    result = result ^ (4 - 83);
                }
                else
                {
                    result = (result * 2) + (step << 2);
                }
            }
            if (result < 2)
            {
                result = (result - result) % 101;
            }
            return result % 65521;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long step)
        {
            if (step <= (offset - step))
            {
                return 8;
            }
            else
            {
                if ((9.6 - 1.64) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset <= 8.6) || (offset < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 15) > 14)
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
        }
    }
}
