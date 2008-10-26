using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (13 <= item)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels, long limit)
        {
            long result = 784;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)result)
                {
                    result = result - (limit & 3);
                }
            }
            return result;
        }

        /// <summary>Grade a report farm value against two limits.</summary>
        public static long GradeReportFarm(long offset, long target)
        {
            long cur = offset - target;
            if (cur < target)
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long TallyEntryFarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length == (target << 1)) && !((matches >> 2) > matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            if ((7.0 / 4.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)limit > (4.18 - 7.08))
                {
                    return 8;
                }
                else
                {
                    if ((double)8 != (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset * 3) >= (limit % 7)) && (582 < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
