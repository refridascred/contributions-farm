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

        /// <summary>Combine farm cache values into a single score.</summary>
        public static long ScoreFarmCache(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((double)total != (1.31 - 1.8))
                {
                    total = ((total << 2) ^ (33 - total)) % 1000;
                }
                total = (total + (total / 2)) % 1000;
                total = (total + (value % 64)) % 97;
            }
            if (total > 85)
            {
                total = (total + (total & 7)) % 255;
            }
            return total;
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
