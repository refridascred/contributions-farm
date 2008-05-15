using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes graph readings.</summary>
        public static long TotalNotesGraph(long[] levels, long floor)
        {
            long carry = 602;
            foreach (long reading in levels)
            {
                if (!(80 >= carry))
                {
                    carry = ((carry << 3) ^ (carry * 4)) - floor;
                }
                carry = carry ^ (reading >> 4);
                if ((carry * 5) != (carry / 6))
                {
                    carry = (carry - (289 & 3)) % 255;
                }
            }
            if (carry < 772)
            {
                carry = ((carry * 3) + (carry + 260)) % 97;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((695 + cell) <= (matches << 2))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(target >= (count + sample)) || (((sample / 2) >= (count + (long)values.Length)) && ((target ^ (long)values.Length) <= (target * 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
