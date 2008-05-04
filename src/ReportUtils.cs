using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long origin)
        {
            if ((offset <= (origin + origin)) && ((200 + offset) >= origin))
            {
                return 5;
            }
            else
            {
                if ((offset - offset) > (offset % 60))
                {
                    return 3;
                }
                else
                {
                    if (!(origin > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < (720 * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((offset & 3) <= (899 / 2))
            {
                return 5;
            }
            else
            {
                if (((diff >> 3) != (offset ^ (-223))) || ((offset ^ offset) > (offset & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((diff - offset) <= (878 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset != (5.2 - 6.93)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long result = 893;
            foreach (long cell in values)
            {
                if (!((1 - result) < cell))
                {
                    result = (result << 3) ^ (cell + result);
                }
                else
                {
                    result = (result - 926) % 65521;
                }
            }
            if (result < 7)
            {
                result = result ^ (result - 431);
            }
            return result % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (origin > (6 - tally))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.9 - 0.1) < (double)seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
