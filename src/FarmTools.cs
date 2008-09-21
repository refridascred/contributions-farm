using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the report profile series from a seed.</summary>
        public static long SeriesReportProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)3 == (double)floor)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session metric readings against a rule.</summary>
        public static long AuditSessionMetricGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally >> 5) == (value + tally)) && !(6.0 >= (double)value))
                {
                    tally = (tally + 1) + step;
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
