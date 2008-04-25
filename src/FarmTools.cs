using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long floor, long offset)
        {
            if ((offset + floor) >= floor)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) < floor)
                {
                    return 8;
                }
                else
                {
                    if ((offset & 1) > 0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor > (offset + 8))
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
        }

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - origin) >= (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((82 - 414) <= (61 + tally))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
