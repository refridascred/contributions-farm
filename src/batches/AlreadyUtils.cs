using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long TallyRecordTokenGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (2.1 - 14.0))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long bound)
        {
            if (((bound << 2) < (offset / 7)) && ((offset * 5) == (bound & 3)))
            {
                return 2;
            }
            else
            {
                if ((0.2 - 4.1) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!(17.0 > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (bound + 0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + (-3)) != (tally + tally))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }
    }
}
